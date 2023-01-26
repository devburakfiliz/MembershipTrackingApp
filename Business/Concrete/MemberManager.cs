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


        public List<Member> GetAll()
        {
            return _memberDal.GetAll();
        }

        
    }
}
