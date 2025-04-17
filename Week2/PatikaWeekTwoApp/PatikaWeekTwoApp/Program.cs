using System;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace PatikaWeekTwoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hafta 2 Kapanış
            // Not: Calistirmak istediginiz kod blogunun öncesi ve sonrasındaki /* ve */ ifadelerini kaldırarak kodu çalıştırıabilirsiniz.

            // 1 - Aşağıdaki çıktıyı yazan bir program.
            // Merhaba
            // Nasılsın ?
            // İyiyim
            // Sen nasılsın ?
            /*
            Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");
            */

            // 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız.Bunların değerlerini atayıp , ekrana yazdırınız.
            /*
            string name = "Ahmet";
            int age = 24;

            Console.WriteLine($"{name} - {age}");
            */

            //3 - Rastgele bir sayı üretip , ekrana yazdırınız.
            /*
            Random random = new Random();
            int rndNum = random.Next();

            Console.WriteLine(rndNum);
            */

            //4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
            /*
            Random random = new Random();
            int rndNum = random.Next();

            Console.WriteLine(rndNum%3);
            */

            //5 - Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
            /*
            int age;

            Console.Write("Lutfen yasinizi giriniz: ");
            age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
            */

            //6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
            }
            */

            //7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
            /*
            string nameOne, nameTwo, tempName;

            Console.Write("Lutfen birinci ismi giriniz: ");
            nameOne = Console.ReadLine(); //Gulse Birsel
            Console.Write("Lutfen ikinci ismi giriniz: ");
            nameTwo = Console.ReadLine(); //Demet Evgar

            Console.WriteLine($"Girdiginiz birinci isim {nameOne}");
            Console.WriteLine($"Girdiginiz ikinci isim {nameTwo}");

            tempName = nameOne;
            nameOne = nameTwo;
            nameTwo = tempName;

            Console.WriteLine($"İsimler yer degistirdikten sonra birinci isim {nameOne}, ikinci isim {nameTwo}");
            */

            //8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
            /*
            void BenDegerDondurmem()
            {
                Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
            }

            BenDegerDondurmem();
            */

            //9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
            /*
            int sum = Sum(10, 15);

            Console.WriteLine(sum);

            int Sum(int num1, int num2)
            {
                return num1 + num2;
            }
            */

            //10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
            /*
            bool isValid;
            Console.WriteLine("True/False degerlerinden birini giriniz!");
            isValid = bool.Parse(Console.ReadLine());

            Console.WriteLine(Validation(isValid));

            bool Validation(bool isValid)
            {
                if (isValid)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            */

            //11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
            /*
            int ageOne, ageTwo, ageThree;
            Console.Write("Birinci kisinin yas degerini giriniz: ");
            ageOne = int.Parse(Console.ReadLine());
            Console.Write("Ikinci kisinin yas degerini giriniz: ");
            ageTwo = int.Parse(Console.ReadLine());
            Console.Write("Ucuncu kisinin yas degerini giriniz: ");
            ageThree = int.Parse(Console.ReadLine());

            Console.WriteLine($"En yasli kisi {Oldest(ageOne, ageTwo, ageThree)} yasindadir.");

            int Oldest(int ageOne, int ageTwo, int ageThree)
            {
                return Math.Max(Math.Max(ageOne, ageTwo), ageThree);
                    
            }
            */

            //12 - Kullanıcıdan sınırsız sayıda sayı alıp, bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
            /*
            int maxNumber = Max([0, -12, 555, 54, 938, -67, 123, -44, 89]);
            Console.WriteLine($"Max number : {maxNumber}");

            int Max(int[] numbers)
            {
                int maxNum = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > maxNum)
                    {
                        maxNum = numbers[i];
                    }
                }
                return maxNum;
            }
            */

            //13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
            /*
            string nameOne, nameTwo;

            Console.Write("Birinci ismi giriniz: ");
            nameOne = Console.ReadLine();
            Console.Write("Ikinci ismi giriniz: ");
            nameTwo = Console.ReadLine();

            Console.WriteLine($"Değiştirilmeden önce: nameOne = {nameOne}, nameTwo = {nameTwo}");

            ChangeNames(ref nameOne, ref nameTwo);

            Console.WriteLine($"Değiştirildikten sonra: nameOne = {nameOne}, nameTwo = {nameTwo}");

            void ChangeNames(ref string nameOne, ref string nameTwo)
            {
                string tempName = nameOne;
                nameOne = nameTwo;
                nameTwo = tempName;
            }
            */

            //14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini(true / false) dönen bir metot.
            /*
            int num;

            Console.Write("Bir sayi giriniz: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(CiftMi(num));

            bool CiftMi(int num)
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            */

            //15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
            /*
            double speed, hour;
            Console.Write("Lutfen hizinizi km cinsinden giriniz: ");
            speed = double.Parse(Console.ReadLine());
            Console.Write("Lutfen süreyi saat cinsinden giriniz: ");
            hour = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Gittiğiniz mesafe {Path(speed, hour)} km'dir.");

            double Path(double speed, double hour)
            {
                return speed * hour;
            }
            */

            //16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
            /*
            int r;
            Console.Write("Lutfen yaricap bilgisini giriniz: ");
            r = int.Parse(Console.ReadLine());

            Console.WriteLine($"{r} cm yaricapli dairenin Alani: {CircleArea(r)}");

            double CircleArea(double radius)
            {
                const double Pi = 3.14159;
                return Pi * Math.Pow(radius, 2);
            }
            */

            //17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.
            /*
            string sentence = "Zaman bir GeRi SayIm";
            Console.WriteLine(sentence.ToUpper());
            Console.WriteLine(sentence.ToLower());
            */

            //18 - "    Selamlar   " metnini bir değişkene atayıp, başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
            /*
            string hello = "    Selamlar   ";
            Console.WriteLine("Bosluklar silinmeden once: ");
            Console.WriteLine(hello);
            Console.WriteLine("Bosluklar silindikten sonra: ");
            Console.WriteLine(hello.Trim());
            */

        }
    }
}