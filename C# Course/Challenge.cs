//Challenge
using System;

namespace C__Course
{
    class Challenge
    {
        public void Survery()
        {
            Console.WriteLine("What is your name?");
            String name = getAnswer();
            Console.WriteLine("How old are you?");
            String age = getAnswer();
            Console.WriteLine("What month were you born in?");
            String monthBorn = getAnswer();
            
            Console.Write("Hi " + name + ". You are " + age + " years old. And you were born in " + monthBorn + ".\n");
        
            //part 2 after challenge
            if (monthBorn == "March")
                Console.WriteLine("You are an Aries.");
            else if (monthBorn == "April")
                Console.WriteLine("You are a Tarus.");
            else if (monthBorn == "May")
                Console.WriteLine("You are a Gemini.");
        }

        public String getAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("Did not input anything. Try again.");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}