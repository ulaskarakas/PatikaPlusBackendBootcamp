using System;

namespace PatikaForApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Soru");
            Console.WriteLine("-------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kendime inaniyorum, ben bu yazilim isini hallederim!");
            }

            Console.WriteLine("\n********************************************************\n");

            Console.WriteLine("2. Soru");
            Console.WriteLine("-------");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n********************************************************\n");

            Console.WriteLine("3. Soru");
            Console.WriteLine("-------");
            Console.WriteLine($"1 ile 20 arasindaki cift sayilar:");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("\n********************************************************\n");

            Console.WriteLine("4. Soru");
            Console.WriteLine("-------");
            int sum = 0;
            for (int i = 50; i <= 150; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"50 ile 150 arasindaki sayilarin toplami {sum}");

            Console.WriteLine("\n********************************************************\n");

            Console.WriteLine("5. Soru");
            Console.WriteLine("-------");
            int sumOdd = 0, sumEven = 0;
            for (int i = 1; i <= 120; i++)
            {
                if (i % 2 != 0)
                {
                    sumOdd = sumOdd + i;
                }
                else
                {
                    sumEven = sumEven + i;
                }
            }
            Console.WriteLine($"1 ile 120 arasindaki tek sayilarin toplami {sumOdd}");
            Console.WriteLine($"1 ile 120 arasindaki cift sayilarin toplami {sumEven}");


        }
    }
}