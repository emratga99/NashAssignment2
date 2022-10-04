using System;
using System.Reflection; 
using System.Linq;

namespace Assignment2
{
          // Find all male members method
        static class Methods{
            static public List<ClassMember> getAllMaleMembers(List<ClassMember> classMembers){
            var maleMemberList = new List<ClassMember>();
            if(classMembers.Count() >0)
                return classMembers.Where(o=>o.gender == EnumGender.MALE).ToList();
            return maleMemberList;
            }
            static public ClassMember FindOldestOne(List<ClassMember> classMembers){
                if(classMembers.Count() >0){
                    return classMembers.Where(o=>o.dateOfBirth == classMembers.Select(o=>o.dateOfBirth).Max()).First();
                }
                    return new ClassMember();
            }   
            static public ClassMember FindFirstOneBornInHanoi(List<ClassMember> classMembers)
            {
                if (classMembers.Count() > 0)
                    classMembers.Where(o=>o.dateOfBirth == classMembers.Where(o=>o.birthPlace.ToLower().Contains("ha noi"))
                    .Select(o=>o.dateOfBirth).Max()).First();
                return new ClassMember();
            }
        }
}
