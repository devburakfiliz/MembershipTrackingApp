
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Gain : IEntity 
    {
        public int Id { get; set; }
        public decimal MemberShipFee { get; set; }
        public int MemberId { get; set; }
        public int InstructorId { get; set; }
    }
}
