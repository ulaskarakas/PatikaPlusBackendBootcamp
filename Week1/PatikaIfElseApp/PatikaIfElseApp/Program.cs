using System;

namespace PatikaIfElseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numResult;
            while (true)
            {
                Console.Write("Lütfen bir sayi giriniz: ");
                string num = Console.ReadLine();
                if (int.TryParse(num, out numResult))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hata: Yanlis bir deger girdiniz!");
                }
            }
            
            if (numResult > 10)
            {
                Console.WriteLine("Girilen sayi 10'dan buyuktur.");
            }
            else if (numResult < 10)
            {
                Console.WriteLine("Girilen sayi 10'dan kucuktur.");
            }
            else
            {
                Console.WriteLine("Girilen sayi 10'a esittir.");
            }

            if (numResult%2 == 0)
            {
                Console.WriteLine("Girilen sayi cifttir.");
            }
            else
            {
                Console.WriteLine("Girilen sayi tektir.");
            }
        }
    }
}


