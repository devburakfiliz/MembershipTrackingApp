using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Member : IEntity
    {
        

     

        public int Id { get; set; }
        public int InstructorId { get; set; }
        public string MemberName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MemberShipFee { get; set; }
        public string Description { get; set; }



    }
}
