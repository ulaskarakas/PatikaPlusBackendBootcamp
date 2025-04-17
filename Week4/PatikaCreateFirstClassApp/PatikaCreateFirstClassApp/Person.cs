using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaCreateFirstClassApp
{
    public class Person
    {
        private string name;
        private string surname;
        private DateTime birthDate;

        public string Name { 
            get { return name; } 
            set { name = value; } 
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public void DisplayPerson(string name, string surname, DateTime birthDate)
        {
            Console.WriteLine($"adi-soyadi: {name} {surname}. Dogum tarihi: {birthDate.ToString("dd.MM.yyyy")}");
        }
    }
}
