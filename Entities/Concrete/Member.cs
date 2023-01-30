using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Member : IEntity
    {
        private object deletedEntity;

     

        public int Id { get; set; }
        public int InstructorId { get; set; }
        public string MemberName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MemberShipFee { get; set; }
        public string Description { get; set; }



    }
}
