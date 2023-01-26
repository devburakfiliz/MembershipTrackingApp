using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryMemberDal : IMemberDal
    {


        List<Member> _members;

        public InMemoryMemberDal()
        {
            _members = new List<Member>
            {
                new Member{ MemberId=1, InstructorId=1, MemberName="Burak",MemberLastName="Filiz",Phone="05432223322",Address="Manisa / merkez",StartingDate=new DateTime(2022,01,1),EndDate=new DateTime(2023,04,1),MembershipFee=750,MemberDescription="ÜYE SAĞLIK SORUNU YOK."},
                new Member{ MemberId=2, InstructorId=1, MemberName="Ceren",MemberLastName="Saldıran",Phone="05432223322",Address="Sinop / merkez",StartingDate=new DateTime(2022,04,1),EndDate=new DateTime(2023,05,1),MembershipFee=250,MemberDescription="ÜYE SAĞLIK SORUNU YOK."},
                new Member{ MemberId=3, InstructorId=1, MemberName="İrem",MemberLastName="Saldıran",Phone="05432223322",Address="Manisa / merkez",StartingDate=new DateTime(2022,03,1),EndDate=new DateTime(2023,05,1),MembershipFee=950,MemberDescription="ÜYE SAĞLIK SORUNU YOK."},
                new Member{ MemberId=4, InstructorId=1, MemberName="Şengün",MemberLastName="Kırlı",Phone="05432223322",Address="Manisa / merkez",StartingDate=new DateTime(2022,02,1),EndDate=new DateTime(2023,07,1),MembershipFee=140,MemberDescription="ÜYE SAĞLIK SORUNU YOK."},
                new Member{ MemberId=5, InstructorId=1, MemberName="Mine",MemberLastName="Saldıran",Phone="05432223322",Address="Manisa / merkez",StartingDate=new DateTime(2022,01,1),EndDate=new DateTime(2023,06,1),MembershipFee=350,MemberDescription="ÜYE SAĞLIK SORUNU YOK."},
            };
        }

        public void Add(Member member)
        {
            _members.Add(member);
        }

        public void Delete(Member member)
        {
            Member DeleteMember = _members.SingleOrDefault(m => m.MemberId == member.MemberId);
            _members.Remove(DeleteMember);
        }

        public List<Member> GetAll()
        {
            return _members;
        }

        public void Update(Member member)
        {
            Member memberUpdate = _members.SingleOrDefault(m => m.MemberId == member.MemberId);
            memberUpdate.MemberId = member.MemberId;
            memberUpdate.InstructorId = member.InstructorId;
            memberUpdate.MemberName = member.MemberName;
            memberUpdate.MemberLastName = member.MemberLastName;
            memberUpdate.Phone = member.Phone;
            memberUpdate.StartingDate = member.StartingDate;
            memberUpdate.EndDate = member.EndDate;
            memberUpdate.Address = member.Address;
            memberUpdate.MembershipFee = member.MembershipFee;
        }
    }
}
