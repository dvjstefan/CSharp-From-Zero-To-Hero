using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }
        public static float CalculateBmi(float weight, float height)
        {
            float bmi = 0;
            bmi = 
                
                weight / height / height;
            return bmi;
        }
        /*
         * 
         * Prompt for input and converting it to int (print message for request, read console input and return converted input to int),
         * Console.Write("Input your name: ");
            // Read line of text from console.
            string name = Console.ReadLine();
            Console.WriteLine("Hello again, " + name);
         * 
         */
        private const string PromptMessage = "Testing";
        public static int PromptInt(string PromptMessage)
        {
            //Console.WriteLine("Enter something: ");
            //string something = Console.ReadLine();
            var x = PromptMessage.ToString();

            Console.WriteLine(x);
            return 0;
        }
    }
}
