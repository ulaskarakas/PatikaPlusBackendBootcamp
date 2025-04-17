using System;

namespace PatikaSwitchCaseApp 
{
    class Program
    {
        static void Main(string[] args)
        {
            int apple = 2, pear = 3, strawberry = 2, banana = 3, other = 4;
            Console.WriteLine("Ruya Manavina Hosgeldiniz!\nElma = 2 TL\nArmut = 3 TL\nCilek = 2 TL\nMuz = 3 TL\nDiger butun meyveler = 4 TL\n");

            while (true) {
                Console.Write("Hangi meyveyi satin almak istersiniz? (Elma/Armut/Cilek/Muz/Diger): ");
                string fruit = Console.ReadLine();
                string lowercaseFruit = fruit.ToLower(); // fruit degiskenini tümüyle kucuk harfe donusturerek buyuk-kucuk harf duyarliligini ortadan kaldirir
                if (lowercaseFruit == "elma" || lowercaseFruit == "armut" || lowercaseFruit == "cilek" || lowercaseFruit == "muz" || lowercaseFruit == "diger")
                {
                    /* If - Else 
                    if (lowercaseFruit == "elma")
                    {
                        Console.WriteLine($"Sectiginiz meyvenin fiyati: {apple} TL");
                        break;
                    }
                    else if (lowercaseFruit == "armut")
                    {
                        Console.WriteLine($"Sectiginiz meyvenin fiyati: {pear} TL");
                        break;
                    }
                    else if (lowercaseFruit == "cilek")
                    {
                        Console.WriteLine($"Sectiginiz meyvenin fiyati: {strawberry} TL");
                        break;
                    }
                    else if (lowercaseFruit == "muz")
                    {
                        Console.WriteLine($"Sectiginiz meyvenin fiyati: {banana} TL");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Sectiginiz meyvenin fiyati: {other} TL");
                        break;
                    }
                    */

                    //Switch - Case yapisinin kullanilmasi bu program icin daha uygun cunku gereksiz kod yazimini onluyor.
                    switch (lowercaseFruit)
                    {
                        case "elma":
                            Console.WriteLine($"Sectiginiz meyvenin fiyati: {apple} TL");
                            break;
                        case "armut":
                            Console.WriteLine($"Sectiginiz meyvenin fiyati: {pear} TL");
                            break;
                        case "cilek":
                            Console.WriteLine($"Sectiginiz meyvenin fiyati: {strawberry} TL");
                            break;
                        case "muz":
                            Console.WriteLine($"Sectiginiz meyvenin fiyati: {banana} TL");
                            break;
                        default:
                            Console.WriteLine($"Sectiginiz meyvenin fiyati: {other} TL");
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Gecersiz bir deger girdiniz: Lütfen sadece Elma/Armut/Cilek/Muz/Diger degerlerinden birini giriniz!");
                }
            }

        }
    }
}