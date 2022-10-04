using System;
using System.Reflection;
using System.Linq; 

namespace Assignment2
{
    class Program{
        static void Main(string[] args){ 
            // initialize variables
            var classMembers = new List<ClassMember>(); 
            var getAllMale = new List<ClassMember>();
            var membersBornBefore2000 = new List<ClassMember>();
            var membersBornIn2000 = new List<ClassMember>();
            var membersBornAfter2000 = new List<ClassMember>();
            var nameList = new List<string>();
            var firstOneBornInHanoi = new ClassMember();
            var oldestOne = new ClassMember();

            // add data
            classMembers.Add(new ClassMember("truong", "trinh", EnumGender.MALE,new DateTime(2000,3,23),
                             "0969696969", "Ha Loi Vietnam", true));
            classMembers.Add(new ClassMember("alonso", "fonso", EnumGender.FEMALE,new DateTime(2000,8,3),
                             "0969698969", "Ha 1oi Viet nam", true));
            classMembers.Add(new ClassMember("chau bac", "ho", EnumGender.MALE,new DateTime(1999,5,13),
                             "0969697969", "Quang Dong Trung Quoc", true));
            classMembers.Add(new ClassMember("ALO ALO", "1234", EnumGender.FEMALE,new DateTime(1999,5,13),
                             "0962327969", "Quang Dong Trung Hoa", true));
            classMembers.Add(new ClassMember("ALO 1234", "1234", EnumGender.FEMALE,new DateTime(2001,5,13),
                             "093422327969", "Ha 1oi dong Hoa", true));
            classMembers.Add(new ClassMember("alonso", "fonso2", EnumGender.MALE,new DateTime(1998,8,3),
                             "0969698969", "Ha Noi Vim", true));

            // console app's loop
            bool inLoop = true;
            while(inLoop)
            {
            Console.WriteLine();
            Console.WriteLine("Enter a key: 1 2 3 4 5. Press X to end:");
            Console.WriteLine("1: Return a list of members who is Male"); 
            Console.WriteLine("2: Return the oldest one based on “Age”"); 
            Console.WriteLine("3: Return a new list that contains Full Name only"); 
            Console.WriteLine("4: Return 3 lists of members who were born before, after and in 2000"); 
            Console.WriteLine("5: Return the first person who was born in Ha Noi"); 
            var key = Console.ReadLine();
            if(key!=null){
                switch(key.ToString().Trim().ToLower()){
                    case("1"):
                    {
                    // first task
                        Console.WriteLine("First Task:");
                        getAllMale = Methods.getAllMaleMembers(classMembers);
                        if(getAllMale!=null && getAllMale.Count() >0){
                            getAllMale.ForEach(o=> Console.WriteLine(o.GetInfo()));
                        }
                        else{
                            Console.WriteLine("There are no male members!");
                        }
                        break;
                    }
                    case("2"):
                    {
                    // second task 
                        Console.WriteLine("Second Task:");
                        oldestOne = Methods.FindOldestOne(classMembers);
                        if(oldestOne!=null){
                            Console.WriteLine(oldestOne.GetInfo());
                        }
                        else{
                            Console.WriteLine("Not Found!");
                        }
                        break;
                    }
                    case("3"):
                    {
                    // third task
                        Console.WriteLine("Third Task:");
                        nameList= classMembers.Select(o=>o.FullName()).ToList(); 
                        nameList.ForEach(o=> Console.WriteLine(o));
                        break;
                    }
                    case("4"):
                    {
                    // forth task
                        Console.WriteLine("Forth Task:");
                        membersBornAfter2000 = classMembers.Where(o=>o.DateOfBirth.Year > 2000).ToList();
                        membersBornIn2000 = classMembers.Where(o=>o.DateOfBirth.Year == 2000).ToList();
                        membersBornBefore2000 = classMembers.Where(o=>o.DateOfBirth.Year < 2000).ToList();
                    
                        Console.WriteLine("Members born after 2000:");
                        membersBornAfter2000.ForEach(o=> Console.WriteLine(o.GetInfo())); 
                        Console.WriteLine("Members born in 2000:");
                        membersBornIn2000.ForEach(o=> Console.WriteLine(o.GetInfo())); 
                        Console.WriteLine("Members born before 2000:");
                        membersBornBefore2000.ForEach(o=> Console.WriteLine(o.GetInfo()));  
                        break;
                    }
                    case("5"):
                    {
                    //fifth task
                        Console.WriteLine("Fifth Task:");
                        firstOneBornInHanoi = Methods.FindFirstOneBornInHanoi(classMembers);
                        if(firstOneBornInHanoi!=null){
                            Console.WriteLine(firstOneBornInHanoi.GetInfo());
                        }
                        else{
                            Console.WriteLine("Not found!");
                        }

                    break;
                    }
                    case("x"):
                    {
                        inLoop = false;
                        break;
                    } 
                    default:
                    {
                        Console.WriteLine("Invalid input!");
                        break;
                    }
                }
            }
            else {
                Console.WriteLine("Invalid input!");
                }
            }
 
        }
    }
}
