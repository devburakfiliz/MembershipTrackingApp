using Core.Ultilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorImageService
    {
        IResult Add(IFormFile file, InstructorImage ınstructorImage);
        IResult Delete(InstructorImage ınstructorImage);
        IResult Update(IFormFile file, InstructorImage ınstructorImage);

        IDataResult<List<InstructorImage>> GetAll(); 
        IDataResult<List<InstructorImage>> GetByCarId(int ınstructorId);
        IDataResult<InstructorImage> GetByImageId(int imageId);
    }
}
