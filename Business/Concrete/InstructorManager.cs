using Business.Abstract;
using Business.Constants;
using Core.Ultilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager :IInstructorService
    {
        IInstructorDal _ınstructorDal;
        public InstructorManager(IInstructorDal ınstructorDal)
        {
            _ınstructorDal = ınstructorDal;
        }
        public IResult Add(Instructor entity)
        {
            _ınstructorDal.Add(entity);
            return new SuccessResult(Messages.InstructorAdded);
        }

        public IResult Delete(Instructor entity)
        {
            _ınstructorDal.Delete(entity);
            return new SuccessResult(Messages.InstructorDeleted);

        }

        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccessDataResult<List<Instructor>>(_ınstructorDal.GetAll(), Messages.InstructorsListed);
        }

        public IResult Update(Instructor entity)
        {
            _ınstructorDal.Update(entity);
            return new SuccessResult(Messages.InstructorUpdated);
        }
    }
}
