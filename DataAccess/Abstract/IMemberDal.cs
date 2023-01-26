using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IMemberDal
    {
        List<Member> GetAll();
        void Add(Member member);
        void Update(Member member);
        void Delete(Member member);
            
    }
}
