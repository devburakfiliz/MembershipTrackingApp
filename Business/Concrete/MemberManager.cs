using Business.Abstract;
using Business.Constants;
using Core.Ultilities.Results;
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

        public IResult Add(Member entity)
        {
            _memberDal.Add(entity);
            return new SuccessResult(Messages.MemberAdded);
        }

        public IResult Delete(Member entity)
        {
            _memberDal.Delete(entity);
            return new SuccessResult(Messages.MemberDeleted);

        }

        public IDataResult< List<Member>> GetAll()
        {
            return new SuccessDataResult<List<Member>>( _memberDal.GetAll(),Messages.MembersListed);
        }

        public IResult Update(Member entity)
        {
            _memberDal.Update(entity);
            return new SuccessResult(Messages.MemberUpdated);
        }
    }
}
