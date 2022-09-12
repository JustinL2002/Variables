using System;

namespace UsingVariablesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 20;
            string myName = "Justin";
            char myNickname = 'J';
            bool isCoding = true;
            double tShirts = 5;
            decimal money = 2.5m;

            Console.WriteLine($"Hello, my name is {myName}, but some people call me {myNickname}, and I am {myAge} years old");
            Console.WriteLine($"Right now, it is {isCoding} that I am coding");
            Console.WriteLine($"I own {tShirts} shirts. Earlier today, I found {money} dollars on the ground" );

            
        }
    }
}

