using Business.Concrete;
using DataAccess.Concrete.FrameWork;
using Entities.Concrete;
using System;

namespace TrackinUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            MemberManager memberManager = new MemberManager(new EfMemberDal());





            //memberManager.Update(new Member { Id = 7, MemberName = "İrem", StartingDate = new DateTime(2023, 3, 23), EndDate = new DateTime(2023, 4, 23), Description = "Bel ağrısı var", Phone = "222", LastName = "Saldıran", Adress = "Manisa", InstructorId = 1, MemberShipFee = 44 });
            // Delete(memberManager);
            //foreach (var member in memberManager.GetAll())
            //{
            //    Console.WriteLine(member.MemberName + "   " + member.LastName + "  " + "ÜYELİK KALAN GÜN SAYISI : " + (member.EndDate - DateTime.Now).Days + " " + member.Adress + " " + ((int)member.MemberShipFee));
            //}

            var result =memberManager.Add(new Member()
            {
               
                MemberName = "İrem",
                LastName = "Saldıran",
                InstructorId = 3,
                MemberShipFee = 700,
                StartingDate = new DateTime(2023, 2, 23),
                EndDate = new DateTime(2023, 7, 23),
                Adress = "Manisa/Bozköy",
                Description = "Bel ağrısı var",
                Phone = "0543303333"

            });
            Console.WriteLine(result.Message+result);















            //foreach (var member in memberManager.GetAll())
            //{
            //    Console.WriteLine(member.MemberName + "   " + member.LastName + "  " + "ÜYELİK KALAN GÜN SAYISI : " + (member.EndDate - DateTime.Now).Days + " " + member.Adress + " " + ((int)member.MemberShipFee));
            //}



        }

        private static void Delete(MemberManager memberManager)
        {
            memberManager.Delete(new Member()
            {

                Id = 3
            });
        }
    }
}
