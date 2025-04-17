using System;

namespace PatikaTravelCompanionHolidayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool validLocation = false, validTransportType = false;
                string location, strNumberOfPerson, trnsportType;
                int intNumberOfPerson, totalPrice = 0;

                Console.WriteLine("Yol Arkadasi: Tatil Uygulamasi'na Hosgeldiniz!");

                // Lokasyon sec
                do
                {

                    Console.WriteLine("**************************************************************************************");
                    Console.WriteLine("3 adet lokasyonumuz var:\nBodrum (Paket baslangic fiyati 4000 TL)\nMarmaris (Paket baslangic fiyati 3000 TL)\nCesme (Paket baslangic fiyati 5000 TL)");
                    Console.Write("Yukaridaki seceneklerden tatil lokasyonunuzu seciniz (Bodrum/Marmaris/Cesme): ");
                    location = Console.ReadLine().ToLower();

                    if (location == "bodrum" || location == "marmaris" || location == "cesme")
                    {
                        validLocation = true;
                    }
                    else
                    {
                        Console.WriteLine("Boyle bir secenek bulunmamaktadir.");
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                    }
                }
                while (!validLocation);

                // Kisi sayisi sec
                while (true)
                {
                    Console.Write("Kac kisilik bir tatil planliyorsunuz? ");
                    strNumberOfPerson = Console.ReadLine();
                    if (int.TryParse(strNumberOfPerson, out intNumberOfPerson))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Boyle bir secenek bulunmamaktadir.");
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                    }
                
                }
            
                // Ulasim tipi sec
                do
                {
                    Console.WriteLine("**************************************************************************************");
                    Console.WriteLine("2 seçeneğimiz var:\n1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\n2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
                    Console.Write("Tatile hangi yolu kullanarak gitmek istersiniz, lutfen seciniz (1/2): ");
                    trnsportType = Console.ReadLine();

                    if(trnsportType == "1" || trnsportType == "2")
                    {
                        validTransportType = true;
                    }
                    else
                    {
                        Console.WriteLine("Boyle bir secenek bulunmamaktadir.");
                    }
                }
                while (!validTransportType);

                // Toplam fiyat hesapla
                switch (location)
                {
                    case "bodrum":
                        totalPrice += 4000;
                        break;
                    case "cesme":
                        totalPrice += 3000;
                        break;
                    case "marmaris":
                        totalPrice += 5000;
                        break;
                }

                if (trnsportType == "1")
                {
                    totalPrice += intNumberOfPerson * 1500;
                }
                else
                {
                    totalPrice += intNumberOfPerson * 4000;
                }

                Console.WriteLine($"Toplam tatil ücreti: {totalPrice} TL");

                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

                Console.WriteLine("Yeni bir hesaplama yapmak istiyor musunuz? (e/h) ");
                var key = Console.ReadKey(true); // Tus girisini al, konsol ekraninda gostermedn devam et

                if (key.Key == ConsoleKey.H) // Eger 'h' tusuna basilirsa
                {
                    break; // Donguden cik
                }
                else
                {
                    Console.Clear(); // Konsol ekranını temizle
                }



            }
        }
    }
}


