namespace PatikaConstructorApp
{
    public class Baby
    {
        // Fields
        private string _name;
        private string _surname;
        private DateTime _birthDate;

        // Constructors
        public Baby()
        {
            Console.WriteLine("Ingaaaa");
        }

        public Baby(string name, string surname)
        {
            _name = name;
            _surname = surname;
            Console.WriteLine("Ingaaaa");
        }

        // Properties
        public string Name { 
            get { return _name; } 
            set { _name = value; } 
        } 

        public string Surname {
            get { return _surname; }
            set { _surname = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        // Methods
        public void DisplayBaby(string name, string surname, DateTime birthDate)
        {
            Console.WriteLine($"adi-soyadi: {name} {surname}. Dogum tarihi: {birthDate.ToString("dd.MM.yyyy")}");
        }

    }
}
