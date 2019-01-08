using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        int count = 0;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("The following question are to see how well you know me.");
            Console.WriteLine("Please answer the following 5 questions.");
            Military();
            Car();
            BirthPlace();
            Country();
            NorthKorea();
            Console.ReadLine();

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
                Console.WriteLine("No, I had served for 2 weeks shy of 11 years."); //displays this if the user answers incorrectly
            }
            return years;

        }


        static string Car() //function for the second question
        {
            Console.WriteLine("What was the Make of my first car?");
            string questTwo = Console.ReadLine();

            if (questTwo == "Volvo")
            {
                Console.WriteLine("That is right, my first car was a Volvo 244GL"); //displays this if the user answers correctly
                return questTwo;
            } else
            {
                Console.WriteLine("Sorry, no, my first car was a Volvo 244GL"); //displays this if the user answers incorrectly
                return questTwo;
            }
            
        }

        static string BirthPlace() //function for the third question
        {
            Console.WriteLine("Which city was I born in?");
            string questThree = Console.ReadLine();
            string city = questThree.ToUpper();

            if (city == "BURIEN")
            {
                Console.WriteLine("That is right, I was born in Burien, Washington."); //displays this if the user answers correctly
                return questThree;
            }
            else
            {
                Console.WriteLine("Sorry, no, I was born in Burien, Washington."); //displays this if the user answers incorrectly
                return questThree;
            }
        }

        static string Country() //function for the fourth question
        {
            Console.WriteLine("Besides the United States, name one of the two other countries I've lived at.");
            string questFour = Console.ReadLine();
            string livedIn = questFour.ToUpper();

            if (livedIn == "QATAR" || livedIn == "KOREA" || livedIn == "SOUTH KOREA" || livedIn == "REPUBLIC OF KOREA")
            {
                Console.WriteLine("Yes, I've lived in the Republic of Korea and Qatar."); //displays this if the user answers correctly
                return questFour;
            }
            else
            {
                Console.WriteLine("Sorry, no, I've lived in the Republic of Korea and Qatar."); //displays this if the user answers incorrectly
                return questFour;
            }
        }

        static string NorthKorea() //function for the fifth question
        {
            Console.WriteLine("Have I ever been to North Korea? Yes or No");
            string questFive = Console.ReadLine();
            string visited = questFive.ToUpper();

            if (visited == "Y" || visited == "YES")
            {
                Console.WriteLine("Yes, while visiting the DMZ, I walked accross a room that half of it was on the South Korean side of the border and the other half was on the North Korean side of the border."); //displays this if the user answers correctly
                return visited;

            } else
            {
                Console.WriteLine("No, I actually have, while visiting the DMZ, I walked accross a room that half of it was on the South Korean side of the border and the other half was on the North Korean side of the border."); //displays this if the user answers correctly
                return visited;
            }
        }

    }
}
