using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MemberManager : IMemberServis
    {

        IMemberDal _memberDal;

        public MemberManager (IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public void Add(Member entity)
        {
            _memberDal.Add(entity);
        }

        public void Delete(Member entity)
        {
            _memberDal.Delete(entity);
            
        }

        public List<Member> GetAll()
        {
            return _memberDal.GetAll();
        }

        public void Update(Member entity)
        {
            _memberDal.Update(entity);
        }
    }
}
