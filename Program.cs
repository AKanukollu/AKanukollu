using System;

namespace myinfo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name please");
            string N = Console.ReadLine();
            Console.WriteLine("Enter your age please");
            string A = Console.ReadLine();
            
           // if (A < 18)
            //    { 
           // Console.ForegroundColor = ConsoleColor.DarkGreen
             //       Console.WriteLine("You are Eligible to vote")
            //   }
           // else
           // { Console.ForegroundColor = ConsoleColor.DarkRed
                //    Console.Writeln("Sorry You are not Eligible to vote")
                  //  (}

            Console.WriteLine("Enter your email-id please");
            string E = Console.ReadLine();
            Console.WriteLine("Enter your address please");
            string D = Console.ReadLine();
            Console.WriteLine("Are you a Veteran ?");
            string V = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("My Info");

            Console.WriteLine(N);
            Console.WriteLine(A);
            Console.WriteLine(E);
            Console.WriteLine(D);
            Console.WriteLine(V);

            


        }
    }
}
