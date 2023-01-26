using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Member : IEntity
    {
        public int MemberId { get; set; }
        public int InstructorId { get; set; }
        public string MemberName { get; set; }
        public string MemberLastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MembershipFee { get; set; }
        public string MemberDescription { get; set; }



    }
}
