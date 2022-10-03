using System;
using System.Reflection; 

namespace Assignment2
{
    enum EnumGender{
        MALE,
        FEMALE,
        OTHERS,
    };
     
    class ClassMember{
        public ClassMember(){}
        public ClassMember(string FirstNameA, string lastNameA,EnumGender genderA, DateTime dateOfBirthA, string phoneNumberA, string birthPlaceA, bool isGraduatedA){
            // "A" suffix is short for argument
            firstName = FirstNameA.Trim();
            lastName = lastNameA.Trim();
            gender = genderA;
            dateOfBirth = dateOfBirthA;
            phoneNumber = phoneNumberA;
            birthPlace = birthPlaceA; 
            isGraduated = isGraduatedA;
        }
        public string firstName;
        public string lastName;
        public EnumGender gender;
        public DateTime dateOfBirth; 
        public string phoneNumber;
        public string birthPlace;
        public int age {get {return getCurrentAge();}}
        public bool? isGraduated;
         public string FullName() { return lastName + " " + firstName; }
        public string GetInfo() { return lastName + " " + firstName + " | " + age + " | " + 
        (gender == EnumGender.MALE?"MALE":gender == EnumGender.FEMALE?"FEMALE":gender == EnumGender.OTHERS?"OTHERS":"") 
        + " | " + dateOfBirth.ToString("dd/MM/yyyy") + " | " + phoneNumber + " | " + birthPlace 
        + " | " + (isGraduated == true?"Graduated":"Not Graduated") ; }
    
            public int getCurrentAge(){
                
            return (DateTime.Now.Year - dateOfBirth.Year) +
                (DateTime.Now.Month < dateOfBirth.Month ?(-1) // if member's birth month is larger than current month then -1
                    :(DateTime.Now.Day < dateOfBirth.Day)?(-1):0); // if member's birth day is larger than current day then -1
        }
    }
}
