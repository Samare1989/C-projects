using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_class_project
{
    class Student
    {
        public int MyProperty { get; set; }
        public string FirstName{get; set;}
        public string LastName;
        public string PhoneNumber;
        public string Email;
        private double _GPA;
        public double GPA;
            private int _SAT;
            public int SAT{ get; set; }
        



        
            else 
            SAT = value;
            }
           set {
                if(value < 0.0 || value > 5.0)

             
               
                       }
                    }
                }
                {
                    Console.WriteLine("GPA Must be between 0 and 5");
                }
                else {

                }
                _GPA = value;

            }
        }
        public int SAT;


        public Student(string fname, string lname, double gpa)
        {
            FirstName = fname;
            LastName = lname;
            PhoneNumber = "513-544-5444";
            Email = "samrawit.amare@ymail.com";
            GPA = gpa;
            SAT = 1230;
        }
            public Student()
            {
                FirstName = "*FirstName";
                LastName = "*LastName";
                PhoneNumber = "513-544-5444";
                Email = "samrawit.amare@ymail.com";
                GPA = 3.69;
                SAT = 1250;
            }
                public Student(string fname, string lname, string phonenumber, double gpa)
            {
                FirstName = fname;
                LastName = lname;
                PhoneNumber = "513-544-5444";
                Email = "samrawit.amare@ymail.com";
                GPA = 3.69;
                SAT = 1250;

            }

        public string FullName()
        {
            return $"{FirstName} { LastName}";

        }
public string Print(string message)
{
    return $"message::" + Print();
}
        public string Print()
        {
            return $"{FirstName} {LastName}| {PhoneNumber}|{Email}|{GPA}|{SAT}";
        }
    }
}
// fix this syntax 