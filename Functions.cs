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
            if (classMembers != null)
            {
                return classMembers.FindAll(o => o.Gender == EnumGender.MALE).ToList();
            }
            return null;
        }

        static public ClassMember FindOldestOne(List<ClassMember> classMembers)
        {
            if (classMembers != null)
            {
                return classMembers.Where(o => o.DateOfBirth == classMembers.Select(o => o.DateOfBirth).Min()).First();
            }
            return null;
        }

        static public ClassMember FindFirstOneBornInHanoi(List<ClassMember> classMembers)
        {
            if (classMembers != null)
            {
                return classMembers.Where(o => o.DateOfBirth == classMembers.Where(o => o.BirthPlace.ToLower()
                    .Contains("ha noi", StringComparison.CurrentCultureIgnoreCase))
                    .Select(o => o.DateOfBirth).Min()).First();
            }
            return null;
        }
    }
}
