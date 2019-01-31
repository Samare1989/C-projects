using System;

// everything to end of line is a comment
namespace hellowworldprojet
{

    class Program
    {
        static int a = 7;
        static void Print()
        {
            Console.WriteLine($"The value of a is {a}");

        }


        static void WhileExample()
        {
            var counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Count is {counter}");
                counter = counter + 1;

                // this program is the Hello,world!
            }
        }
        static void Main(string[] args)


        {
            var counter = "0";

            var b = 13;
            var c = a * b;
            System.Console.WriteLine("Hello,World!");
            Console.WriteLine("by Sammy");
            Console.WriteLine($"for a = {a} and b = {b}, a * b = {c}");
            Console.WriteLine($"Value of counter is { counter}");


        }
    }
}
