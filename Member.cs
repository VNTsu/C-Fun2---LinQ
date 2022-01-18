using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Học1
{
     class Member
    {
        public String FirtName { get; set; }
        public String LastName { get; set; }
        public TypeGender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String PhoneNumber { get; set; }
        public String BirthPlace { get; set; }
        public int Age { get; set; }
        public bool Graduated { get; set; }
        public Member (String inputFirtName, String inputLastName, TypeGender InputGender, DateTime inputDate, String inputPhoneNumber, String inputBirdPlace, int inputAge, bool inputGraduated)
        {
            this.FirtName = inputFirtName;
            this.LastName = inputLastName;
            this.Gender = InputGender;
            this.DateOfBirth = inputDate;
            this.PhoneNumber = inputPhoneNumber;
            this.BirthPlace = inputBirdPlace;
            this.Age = inputAge;
            this.Graduated = inputGraduated;
        }
       
        public Member() { }
    }   
    public enum TypeGender
    {
        Male = 1,
        Female = 2,
    }
   

}
