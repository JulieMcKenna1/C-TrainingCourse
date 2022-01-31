//Cahlleneg3 - Loop Counting

// count from 1 - 10 and then back to 1, do that 5 times. Do NOT use if statements

using System;

namespace C__Course
{
    class Challenge3
    {
        public void LoopCounting()
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine("Outter loop count: " + j);
                for (int i = 1; i <= 10; i++)
                    Console.WriteLine(i);
                for (int i = 10; i >= 1; i--)
                    Console.WriteLine(i);
            }
        }
    }
}
