using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_class_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var Sammy = new Student();
         
            var chris = new Student();
            var ken = new Student();
            var irena = new Student();
            var ben = new Student();
            var seth = new Student();
            var Kellan = new Student(" Kellen", "Keith",3.7);

            Console.WriteLine(seth.Print());
            seth.PhoneNumber = 523-456-7899
             Console.WriteLine(seth.print("changed seth.phone number"));
            Console.WriteLine(seth.Print(" New Print Method"));
            Sammy.FirstName = "Sammy";
            Sammy.LastName = "Amare";
            var str = Sammy.FirstName;
            Sammy.GPA = 3.69;
            Sammy.SAT = 1250;
            Sammy.PhoneNumber = "513-225-2626";
            Console.WriteLine(Sammy.Print());
            chris.FirstName = "Chris";
            chris.LastName = "Caudill";
            chris.GPA = 3.89;
            chris.SAT = 1250;
            chris.PhoneNumber = "513-66-2121";
            Console.WriteLine(chris.Print());
            var C = chris.FirstName;
             var sammyfullname = Sammy.FullName();




        }
    }
}
