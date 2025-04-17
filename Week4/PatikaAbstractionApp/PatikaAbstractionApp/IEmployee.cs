namespace PatikaAbstractionApp
{
    public interface IEmployee
    {
        // Properties
        public string Name { get; set; }   
        public string Surname { get; set; }
        public string Department { get; set; }

        // Method
        public void Task();

    }

    public class SoftwareDeveloper : IEmployee
    {
        // Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        // Constructor
        public SoftwareDeveloper(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }

        // Method
        public void Task()
        {
            Console.WriteLine($"My name is {Name} {Surname}. I'm working as Software Developer in {Department} Department.");
        }
    }

    public class ProjectManager : IEmployee
    {
        // Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        // Constructor
        public ProjectManager(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }

        // Method
        public void Task()
        {
            Console.WriteLine($"My name is {Name} {Surname}. I'm working as Project Manager in {Department} Department.");
        }
    }

    public class SalesRepresentative : IEmployee
    {
        // Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        // Constructor
        public SalesRepresentative(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }

        // Method
        public void Task()
        {
            Console.WriteLine($"My name is {Name} {Surname}. I'm working as Sales Representative in {Department} Department.");
        }
    }
}
