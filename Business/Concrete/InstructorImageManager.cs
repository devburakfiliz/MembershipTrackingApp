using Business.Abstract;
using Business.Constants;
using Core.Ultilities.Business;
using Core.Ultilities.Helpers.FileHelper;
using Core.Ultilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorImageManager : IInstructorImageService
    {

        IInstructorImageDal _ınstructorImageDal;
        IFileHelper _fileHelper;
        public InstructorImageManager(IInstructorImageDal ınstructorImageDal,IFileHelper fileHelper)
        {
            _ınstructorImageDal = ınstructorImageDal;
            _fileHelper = fileHelper;
        }


        public IResult Add(IFormFile file, InstructorImage ınstructorImage)
        {
            IResult result = BusinessRules.Run(CheckIfInstructorImageLimit(ınstructorImage.InstructorId));
            if (result != null)
            {
                return result;
            }
            ınstructorImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            ınstructorImage.Date = DateTime.Now;
            _ınstructorImageDal.Add(ınstructorImage);
            return new SuccessResult("Resim başarıyla yüklendi");
        }

        public IResult Delete(InstructorImage ınstructorImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<InstructorImage>> GetAll()
        {
            return new SuccessDataResult<List<InstructorImage>>(_ınstructorImageDal.GetAll());
        }

        public IDataResult<List<InstructorImage>> GetByCarId(int ınstructorId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<InstructorImage> GetByImageId(int imageId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(IFormFile file, InstructorImage ınstructorImage)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfInstructorImageLimit(int carId)
        {
            var result = _ınstructorImageDal.GetAll(i => i.InstructorId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
    }
}
