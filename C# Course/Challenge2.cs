//Challenge2 - Passcode
using System;

namespace C__Course
{
    class Challenge2
    {
        public void Passcode()
        {
            Console.WriteLine("What is the passcode?");
            var code = Console.ReadLine();
            
            while(code != "secret")
            { 
                Console.WriteLine("You are not authenticated. Passwords to not match");
                code = Console.ReadLine();
            } 
            Console.WriteLine("You are authenticated.");
        }
    }
}
