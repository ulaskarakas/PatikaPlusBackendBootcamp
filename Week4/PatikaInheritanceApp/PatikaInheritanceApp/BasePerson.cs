namespace PatikaInheritanceApp
{
    public abstract class BasePerson
    {
        // Properties
        public string Name { get; set; }
        public string Surname { get; set; }

        // Method
        public abstract void Introduce();

    }

    public class Student : BasePerson
    {
        // Property
        public int StudentNumber { get; set; }

        // Constructor
        public Student(string name, string surname, int studentNumber)
        {
            Name = name;
            Surname = surname;
            StudentNumber = studentNumber;
        }

        // Method
        public override void Introduce()
        {
            Console.WriteLine($"Student Number: {StudentNumber} / Name: {Name} / Surname: {Surname}");
        }
    }

    public class Teacher : BasePerson
    {
        // Property
        public int Salary { get; set; }

        // Constructor
        public Teacher(string name, string surname, int salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        // Method
        public override void Introduce()
        {
            Console.WriteLine($"Salary: {Salary} TL / Name: {Name} / Surname: {Surname}");
        }
    }

}
