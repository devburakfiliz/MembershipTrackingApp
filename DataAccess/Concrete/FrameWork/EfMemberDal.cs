using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.FrameWork
{
    public class EfMemberDal : IMemberDal
    {
        public void Add(Member entity)
        {
            using (MemberContext context=new MemberContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Member entity)
        {
            using (MemberContext context = new MemberContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Member Get(Expression<Func<Member, bool>> filter)
        {
            using (MemberContext context = new MemberContext())
            {
                return context.Set<Member>().SingleOrDefault(filter);

            }
        }

        public List<Member> GetAll(Expression<Func<Member, bool>> filter = null)
        {
            using (MemberContext context = new MemberContext())
            {
                return filter == null
                    ? context.Set<Member>().ToList()
                    : context.Set<Member>().Where(filter).ToList();
            }
        }

        public void Update(Member entity)
        {
            using (MemberContext context = new MemberContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
