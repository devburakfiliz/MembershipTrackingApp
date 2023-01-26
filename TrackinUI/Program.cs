using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace TrackinUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberManager memberManager = new MemberManager(new InMemoryMemberDal());

            foreach (var member in memberManager.GetAll())
            {
                Console.WriteLine(member.MemberName+"   "+member.MemberLastName+"  "+"ÜYELİK KALAN GÜN SAYISI : "+(member.EndDate-DateTime.Now).Days);
            }
        }
    }
}
