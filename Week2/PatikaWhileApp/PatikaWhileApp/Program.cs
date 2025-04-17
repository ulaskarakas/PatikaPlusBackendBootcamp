using System;

namespace PatikaWhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Soru");
            Console.WriteLine("-------");
            int counterOne = 10;
            while (counterOne > 0)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                counterOne--;
            }

            Console.WriteLine("\n********************************************************\n");

            Console.WriteLine("2. Soru");
            Console.WriteLine("-------");
            int counterTwo = 1;
            while (counterTwo <= 20)
            {
                Console.WriteLine(counterTwo);
                counterTwo++;
            }

            Console.WriteLine("\n********************************************************\n");

            Console.WriteLine("3. Soru");
            Console.WriteLine("-------");
            Console.WriteLine($"1 ile 20 arasindaki cift sayilar:");
            int counterThree = 1;
            while (counterThree <= 20)
            {
                if (counterThree%2 == 0)
                {
                    Console.WriteLine(counterThree);
                }
                counterThree++;
            }

            Console.WriteLine("\n********************************************************\n");

            Console.WriteLine("4. Soru");
            Console.WriteLine("-------");
            int counterFour = 50;
            int sum = 0;
            while (counterFour <= 150)
            {
                sum = sum + counterFour;
                counterFour++;
            }
            Console.WriteLine($"50 ile 150 arasindaki sayilarin toplami {sum}");


            Console.WriteLine("\n********************************************************\n");

            Console.WriteLine("5. Soru");
            Console.WriteLine("-------");
            int counterFive = 1;
            int sumOdd = 0, sumEven = 0;
            while (counterFive <= 120)
            {
                if (counterFive%2 != 0)
                {
                    sumOdd = sumOdd + counterFive;
                }
                else
                {
                    sumEven = sumEven + counterFive;
                }
                counterFive++;
            }
            Console.WriteLine($"1 ile 120 arasindaki tek sayilarin toplami {sumOdd}");
            Console.WriteLine($"1 ile 120 arasindaki cift sayilarin toplami {sumEven}");



        }
    }
}