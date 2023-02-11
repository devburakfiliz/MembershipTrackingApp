using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class InstructorImage :IEntity
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
