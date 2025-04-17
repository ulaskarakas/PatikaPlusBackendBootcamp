using System;

namespace PatikaDoWhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            Console.Write("Lutfen bir limit degeri belirleyiniz: ");

            while (true)
            {
                string limit = Console.ReadLine();
                if (int.TryParse(limit, out int limitResult))
                {
                    if (limitResult >= 0)
                    {
                        /*
                        while (counter <= limitResult)
                        {
                            Console.WriteLine("Ben bir Patika'lıyım");
                            counter++;
                        }
                        */
                        do
                        {
                            Console.WriteLine("Ben bir Patika'lıyım");
                            counter++;
                        }
                        while (counter <= limitResult);

                        break;
                    }
                    else
                    {
                        Console.Write("Negatif bir sayı girdiniz. Lütfen pozitif bir tam sayı girin: ");
                    }
                }
                else
                {
                    Console.Write("Geçerli bir sayı girmediniz. Lütfen bir tam sayı girin: ");
                }
            }

            /* 
             * while ve do-while ayni islevi görüyor ciktilari limit 0 olarak belirlenmezse sürekli ayni oluyor. 
             * do-while'da sart kontrolu yapilmadan önce islemler en az bir kere gerceklesiyor. 
             * Kullanimi duruma göre degisir. Bazi durumlarda while, bazı durumlarda do-while kullanilabilir. 
             */
            
        }
    }
}