using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Gain:IEntity
    {
        public int InstructorId { get; set; }
        public int MembershipFee { get; set; }
        public int Expense { get; set; }
        public int OtherGain { get; set; }



    }
}
