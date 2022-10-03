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
            foreach(var member in classMembers){
                if(member.gender == EnumGender.MALE)
                maleMemberList.Add(member);
            }
            return maleMemberList;
            }
            static public ClassMember FindOldestOne(List<ClassMember> classMembers){
                if(classMembers.Count() >0){
                    int index = 0; 
                    for(int i = 0; i < classMembers.Count();i++)
                    if(DateTime.Compare(classMembers[index].dateOfBirth,classMembers[i].dateOfBirth) > 0 ){
                        index = i;
                    }
                    return classMembers[index];
                }
                    return new ClassMember();
            }   
            static public ClassMember FindFirstOneBornInHanoi(List<ClassMember> classMembers)
            {
                if (classMembers.Count() > 0)
                    foreach(ClassMember member in classMembers)
                        if (member.birthPlace.ToLower().Contains("ha noi"))
                        {
                            return member;
                        }  
                return new ClassMember();
            }
        }
}
