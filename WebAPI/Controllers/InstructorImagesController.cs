using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorImagesController : ControllerBase
    {
        IInstructorImageService _ınstructorImageService;
        public InstructorImagesController(IInstructorImageService ınstructorImageService)
        {
            _ınstructorImageService = ınstructorImageService;
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile file, [FromForm] InstructorImage ınstructorImage)
        {
            var result = _ınstructorImageService.Add(file, ınstructorImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(InstructorImage ınstructorImage)
        {
            var carDeleteImage = _ınstructorImageService.GetByImageId(ınstructorImage.Id).Data;
            var result = _ınstructorImageService.Delete(carDeleteImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update([FromForm] IFormFile file, [FromForm] InstructorImage carImage)
        {
            var result = _ınstructorImageService.Update(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _ınstructorImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycarıd")]
        public IActionResult GetByCarId(int carId)
        {
            var result = _ınstructorImageService.GetByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        [HttpGet("getbyimageid")]
        public IActionResult GetByImageId(int imageId)
        {
            var result = _ınstructorImageService.GetByImageId(imageId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }

}
