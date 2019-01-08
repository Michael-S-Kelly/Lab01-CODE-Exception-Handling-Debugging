using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("The following question are to see how well you know me.");
            Console.WriteLine("Please answer the following 5 questions.");
            Military();

        }

        static int Military() //function for the first question
        {
            Console.WriteLine("How many years did I Serve in the U.S. Military?");
            string questOne = Console.ReadLine();
            int years = Convert.ToInt32(questOne);

            if (years == 11)
            {
                Console.WriteLine("That is right, I served for 2 weeks shy of 11 years."); //displays this if the user answers correctly
            }
            else
            {
                Console.WriteLine("No, I had served for 2 weeks shy of 11 years.");
            }

        }

        static string Car()
        {

        }


    }
}
