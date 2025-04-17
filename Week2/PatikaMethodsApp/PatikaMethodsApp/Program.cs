using System;

namespace PatikaMethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("1. Method");
            program.Lyrics();

            Console.WriteLine("-*-*-**-*-*-*-*-*-*-*-*-*-");

            Console.WriteLine("2. Method");
            Console.WriteLine(program.RandomModTwo());

            Console.WriteLine("-*-*-**-*-*-*-*-*-*-*-*-*-");

            Console.WriteLine("3. Method");
            Console.Write("Carpma islemi icin 1. sayiyi giriniz: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Carpma islemi icin 2. sayiyi giriniz: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Carpma isleminin sonucu: {program.Product(num1, num2)}");

            Console.WriteLine("-*-*-**-*-*-*-*-*-*-*-*-*-");

            Console.WriteLine("4. Method");
            Console.Write("Adinizi giriniz: ");
            string name = Console.ReadLine();
            Console.Write("Soadinizi giriniz: ");
            string surname = Console.ReadLine();
            program.Welcome(name, surname);

        }

        // 1. Method
        // Konsola sarki sözlerini yazdirir
        public void Lyrics()
        {
            Console.WriteLine("Nothing Else Matter");
        }

        // 2. Method
        // Random bir sayi olusturarak mod%2 degerini hesaplar
        public int RandomModTwo()
        {
            Random random = new Random();
            int num = random.Next(1,500);
            return num % 2;
        }

        // 3. Method
        // Girilen 2 sayiyi carpar
        public int Product(int num1, int num2)
        {
            return num1 * num2;
        }

        // 4. Method
        // Girilen isim ve soyisim degerleri alarak ekrana yazdırır
        public void Welcome(string name, string surname)
        {
            Console.WriteLine($"Hoş Geldiniz {name} {surname}");
        }
    }
}