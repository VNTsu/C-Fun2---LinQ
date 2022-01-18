using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Học1
{
    class Process
    {
        public List<Member> ListMale (List<Member> member)
        {
            return member.Where(m => m.Gender.ToString().Equals("Male")).ToList();
        }
        public Member Oldest (List<Member> member)
        {
            return member.Where(m => m.Age == member.Max(m => m.Age)).First();
        }
        public List<Member> List2k(List<Member> member)
        {
            return member.Where(m => m.DateOfBirth.Year == 2000 ).ToList();
        }
        public List<Member> ListMore2K(List<Member> member)
        {
            return member.Where(m => m.DateOfBirth.Year > 2000).ToList();
        }
        public List<Member> Listunder2k(List<Member> member)
        {
            return member.Where(m => m.DateOfBirth.Year < 2000).ToList();
        }
        public Member ListHn(List<Member> member)
        {
            return member.Where(m => m.BirthPlace == "HaNoi").First();
        }
        public List<Member> FullMember (List<Member> member)
        {
            return member;
        }
    }
}
