using Core.Ultilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        IDataResult<List<Instructor>> GetAll();
        IResult Add(Instructor entity);
        IResult Update(Instructor entity);
        IResult Delete(Instructor entity);

    }
}
