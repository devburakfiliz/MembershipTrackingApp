using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Instructor : IEntity
    {
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string InstructorLastName { get; set; }
        public string InstructorPhone { get; set; }

    }
}
