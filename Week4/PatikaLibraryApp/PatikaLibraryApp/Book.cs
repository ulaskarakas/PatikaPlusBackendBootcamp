namespace PatikaLibraryApp
{
    public class Book
    {
        // Fields
        private string _name;
        private string _writerName;
        private string _writerSurname;
        private int _numbersOfPage;
        private string _publisher;
        private DateTime _recordDate;

        // Properties
        public string Name {  get { return _name; } set { _name = value; } }
        public string WriterName { get { return _writerName; } set { _writerName = value; } }
        public string WriterSurname { get { return _writerSurname;} set { _writerSurname = value; } }
        public int NumbersOfPage { get { return _numbersOfPage; } set { _numbersOfPage = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public DateTime DateTime { get { return _recordDate; } set { _recordDate = value; } }

        // Constructors
        public Book()
        {
            _recordDate = DateTime.Now;
        }

        public Book(string name, string writerName, string writerSurname, int numbersOfPage, string publisher)
        {
            _recordDate = DateTime.Now;
            Console.WriteLine($"Kitap Adi: {name} / Yazar Adi-Soyadi: {writerName} {writerSurname} / Sayfa Sayisi: {numbersOfPage} / Yayinevi: {publisher} / Kayit Tarihi: {_recordDate.ToString("dd-MM-yyyy")}");
        }

        // * Class *
        // Class, bir nesnenin şablonudur. İçerisinde özellikler (properties) ve davranışlar (methods) tanımlanır.
        // Örneğin; bir "Araba" sınıfı düşünelim. Bu sınıf, tüm arabalar için ortak özellikleri ve davranışları içerir.
        // class Araba { ... }

        // * Property *
        // Class içerisindeki değişkenlere veya verilere erişimi sağlayan yapılardır. Özellikler, genelde bir nesnenin durumunu temsil eder.
        // Araba sınıfı örneğini devam ettirecek olursak; Marka, Model, ve Yıl sınıfın özellikleridir. Her bir araba nesnesi bu özelliklere farklı değerler atanabilir.
        // public string Marka { get; set; }

        // * New *
        // new anahtar kelimesi, bir sınıftan yeni bir nesne oluşturmak için kullanılır.
        // Araba benimArabam = new Araba();

        // * Constructor *
        // Constructor, bir sınıftan nesne oluşturulurken çalışan özel bir metottur. Genelde nesnenin başlangıç değerlerini ayarlamak için kullanılır.
        // public Araba(string marka, string model) {}

        // Bunların tümüne örnek verecek olursak;
        /*
        class Araba
        {
            // Properties
            public string Marka { get; set; }
            public string Model { get; set; }
            public int Yil { get; set; }

            // Constructor
            public Araba(string marka, string model, int yil)
            {
                Marka = marka;
                Model = model;
                Yil = yil;
            }
        }

        Araba benimArabam = new Araba("Honda", "Civic", 2021); // şeklinde yeni bir araba nesnesi oluşturulabilir.
        */

    }
}
