using System;

namespace PatikaWhoWantsToBeMillionaireApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, answer;
            int correct = 0; // Toplam dogru sayisini tutmak icin tanimlandi ve baslangicda 0 degeri atandi

            Console.WriteLine("Kim Milyoner Olmak Ister Yarismasina Hosgeldiniz!\n");
            Console.Write("Yarismaci isminizi girebilir misiniz?: ");
            name = Console.ReadLine();

            // Birinci soru
            Console.WriteLine("\n1->Kizinca tukuren hayvan hangisidir?\na) Lama b) Deve ");
            while (true)
            {
                Console.Write("Cevabinizi alabilir miyiz lutfen?: ");
                answer = Console.ReadLine().ToUpper();
                // A(a) ya da B(b) disinda bir deger girilmemesi icin kontrol yapildi
                if (answer == "A" || answer == "B")
                {
                    if (answer == "A")
                    {
                        Console.WriteLine("Dogru cevap verdiniz:) Simdi bir sonraki soruya geciyoruz.");
                        correct++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yanlis cevap verdiniz:( Dogru cevap a secenegi olacakti. Simdi bir sonraki soruya geciyoruz.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("a ya da b secenegini seciniz lutfen.");
                }
            }

            // Ikinci soru
            Console.WriteLine("\n2 -> Dunya'ya en yakin gezegen hangisidir ?\na) Merkur b) Mars ");
            while (true)
            {
                Console.Write("Cevabinizi alabilir miyiz lutfen?: ");
                answer = Console.ReadLine().ToUpper();
                // A(a) ya da B(b) disinda bir deger girilmemesi icin kontrol yapildi
                if (answer == "A" || answer == "B")
                {
                    if (answer == "A")
                    {
                        Console.WriteLine("Dogru cevap verdiniz:)");
                        correct++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yanlis cevap verdiniz:( Dogru cevap a secenegi olacakti. Simdi bir sonraki soruya geciyoruz.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("a ya da b secenegini seciniz lutfen.");
                }
            }

            // Dogru cevap sayisi kontrolu yapildi, duruma gore ucuncu soru sorulup sorulmayacagi belirlendi
            if (correct == 0)
            {
                Console.WriteLine("Kazanmak icin en az 2 soru bilmeniz gerekiyordu. Kaybettiniz:(");
            }
            else if (correct == 1)
            {
                // Ucuncu soru
                Console.WriteLine("\n3 -> 5 * 2 + 8 / 2 - 2 isleminin sonucu kactir ? \na) 7 b) 12 ");
                while (true)
                {
                    Console.Write("Cevabinizi alabilir miyiz lutfen?: ");
                    answer = Console.ReadLine().ToUpper();
                    // A(a) ya da B(b) disinda bir deger girilmemesi icin kontrol yapildi
                    if (answer == "A" || answer == "B")
                    {
                        if (answer == "B")
                        {
                            Console.WriteLine("Dogru cevap verdiniz:)");
                            Console.WriteLine("Yarismayi kazandiniz. 1 Milyon TL sizin oldu.TEBRIKLER!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yanlis cevap verdiniz:( Dogru cevap a secenegi olacakti. Simdi bir sonraki soruya geciyoruz.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("a ya da b secenegini seciniz lutfen.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Yarismayi kazandiniz. 1 Milyon TL sizin oldu.TEBRIKLER!");
            }

        }
    }
}