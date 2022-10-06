using System;
using System.Reflection;

namespace Assignment2
{
    enum EnumGender
    {
        MALE,
        FEMALE,
        OTHERS,
    };

    class ClassMember
    {
        public ClassMember() { }
        public ClassMember(string firstNameA, string lastNameA, EnumGender genderA, DateTime dateOfBirthA, string phoneNumberA, string birthPlaceA, bool isGraduatedA)
        {
            // "A" suffix is short for argument
            FirstName = firstNameA.Trim();
            LastName = lastNameA.Trim();
            Gender = genderA;
            DateOfBirth = dateOfBirthA;
            PhoneNumber = phoneNumberA;
            BirthPlace = birthPlaceA;
            IsGraduated = isGraduatedA;
        }
        // property declaration
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get { return getCurrentAge(); } }
        public bool? IsGraduated { get; set; }

        // methods
        public string FullName() { return LastName + " " + FirstName; }
        public string GetInfo()
        {
            return LastName + " " + FirstName + " | " + Age + " | " + getGender(Gender)
                + " | " + DateOfBirth.ToString("dd/MM/yyyy") + " | " + PhoneNumber + " | " + BirthPlace
                + " | " + (IsGraduated == true ? "Graduated" : "Not Graduated");
        }
        public string getGender(EnumGender gender)
        {
            return (Gender == EnumGender.MALE ? "MALE"
                : Gender == EnumGender.FEMALE ? "FEMALE"
                : Gender == EnumGender.OTHERS ? "OTHERS" : "");
        }
        public int getCurrentAge()
        {
            return (DateTime.Now.Year - DateOfBirth.Year) +
                (DateTime.Now.Month < DateOfBirth.Month ? (-1)
                // if member's birth month is larger than current month then -1
                : (DateTime.Now.Day < DateOfBirth.Day) ? (-1) : 0);
            // if member's birth day is larger than current day then -1
        }
    }
}
