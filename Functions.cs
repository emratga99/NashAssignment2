using System;
using System.Reflection;
using System.Linq;

namespace Assignment2
{
    // Find all male members method
    static class Methods
    {
        static public List<ClassMember> getAllMaleMembers(List<ClassMember> classMembers)
        {
            if (classMembers.Any())
            {
                return classMembers.FindAll(o => o.Gender == EnumGender.MALE).ToList();
            }
            return new List<ClassMember>();
        }

        static public ClassMember FindOldestOne(List<ClassMember> classMembers)
        {
            if (classMembers.Any())
            {
                return classMembers.FirstOrDefault(o => o.DateOfBirth == classMembers.Min(o => o.DateOfBirth));;
            }
            return null;
        }

        static public ClassMember FindFirstOneBornInHanoi(List<ClassMember> classMembers)
        {
            if (classMembers.Any())
            {
                return classMembers.FirstOrDefault(o => o.BirthPlace.ToLower()== "ha noi");
            }
            return null;
        }
    }
}
