//switch
using System;

namespace C__Course
{
    class JobCanidate
    {
        public void Swicth()
        {
            Console.WriteLine("How many years od experience do you have?");

            var years = int.Parse(Console.ReadLine());

            switch (years)
            {
                case 0:
                    Console.WriteLine("Inexperienced");
                    break;
                case 1:
                    Console.WriteLine("Junior");
                    break;
                case 2:
                    Console.WriteLine("Intermediate");
                    break;
                case 3:
                    Console.WriteLine("Advanced");
                    break;
                default:
                    Console.WriteLine("Senior");
                    break;
            }
        }
    }
}