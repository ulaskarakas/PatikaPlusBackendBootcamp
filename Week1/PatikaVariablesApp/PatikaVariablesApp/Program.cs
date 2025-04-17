using System;

namespace PatikaVariablesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanilacak degiskenler tanimlandi.
            string identityNumber, name, surname, phoneNumber, age, firstPrice, secondPrice;

            Console.WriteLine("Lutfen asagidaki bilgileri giriniz:");

            //Degiskenler icin kullanicidan giris istendi ve degiskenlere atandi.
            Console.Write("T.C. Kimlik Numarasi: ");
            identityNumber =  Console.ReadLine();
            // T.C. kimlik numarasi verisini saklamak icin string tipinde bir degisken kullanildi cunku bu numara ile herhangi bir aritmetik islem yapilmadi.
            Console.Write("Adi: ");
            name = Console.ReadLine();
            // Ad verisini saklamak icin string tipinde bir degisken kullanildi cunku bu numara ile herhangi bir aritmetik islem yapilmadi.
            Console.Write("Soyadi: ");
            surname = Console.ReadLine();
            // Soyad verisini saklamak icin string tipinde bir degisken kullanildi cunku bu numara ile herhangi bir aritmetik islem yapilmadi.
            Console.Write("Telefon Numarasi: ");
            phoneNumber = Console.ReadLine();
            // Telefon numarasi verisini saklamak icin string tipinde bir degisken kullanildi cunku bu numara ile herhangi bir aritmetik islem yapilmadi.
            Console.Write("Yas: ");
            age = Console.ReadLine();
            // Yas verisini saklamak icin string tipinde bir degisken kullanildi cunku bu numara ile herhangi bir aritmetik islem yapilmadi.
            int priceResultOne, priceResultTwo;
            while (true)
            {
                Console.Write("Ilk Aldigi Ürünün Fiyati: ");
                firstPrice = Console.ReadLine();
                /* 
                 * Ilk alinan urun fiyati verisini saklamak icin string tipinde bir degisken kullanildi ancak,
                 * TryParse metodu ile tur donusumu yapilarak int bir degiskene donusturuldu cunku daha sonra aritmetik bir islemler yapildi.
                */
                if (int.TryParse(firstPrice, out priceResultOne))
                {
                    break; // Donusum basariliysa donguden cik.
                }
                else
                {
                    Console.WriteLine("Hata: Geçersiz bir deger girdiniz. Lütfen bir sayı girin.");
                }
            }

            while (true)
            {
                Console.Write("Ikinci Aldigi Ürünün Fiyati: ");
                secondPrice = Console.ReadLine();
                /* 
                 * Ikinci alinan urun fiyati verisini saklamak icin string tipinde bir degisken kullanildi ancak,
                 * TryParse metodu ile tur donusumu yapilarak int bir degiskene donusturuldu cunku daha sonra aritmetik bir islemler yapildi.
                */
                if (int.TryParse(secondPrice, out priceResultTwo))
                {
                    break; // Donusum basariliysa donguden cik.
                }
                else
                {
                    Console.WriteLine("Hata: Geçersiz bir deger girdiniz. Lütfen bir sayı girin.");
                }
            }

            // Toplam fiyat ve puan bilgisi hesaplandi.
            int totalPrice = priceResultOne + priceResultTwo;
            double patikaPoint = totalPrice / 10;
            // Cikti console ekranına basildi.
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"{identityNumber} T.C. numarali {name} {surname} isimli kisi icin kayit olusturulmustur.\n{phoneNumber} telefon numarasina bildirim mesaji gonderilmistir.");
            Console.WriteLine($"{totalPrice} toplam harcama karsiligi kazanilan 10%  patika puan miktari -> {patikaPoint} TL'dir.");
        }
    }
}