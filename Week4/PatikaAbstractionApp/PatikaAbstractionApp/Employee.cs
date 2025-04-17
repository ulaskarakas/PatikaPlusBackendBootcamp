namespace PatikaAbstractionApp
{
    public abstract class Employee
    {
        // Properties
        public string Name {  get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        // Method
        public abstract void Task();

    }

    public class SoftwareDeveloperWithClass : Employee
    {
        public SoftwareDeveloperWithClass(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }

        public override void Task()
        {
            Console.WriteLine($"My name is {Name} {Surname}. I'm working as Software Developer in {Department} Department.");
        }
    }

    public class ProjectManagerWithClass : Employee
    {
        public ProjectManagerWithClass(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }

        public override void Task()
        {
            Console.WriteLine($"My name is {Name} {Surname}. I'm working as Software Developer in {Department} Department.");
        }
    }

    public class SalesRepresentativeWithClass : Employee
    {
        public SalesRepresentativeWithClass(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }

        public override void Task()
        {
            Console.WriteLine($"My name is {Name} {Surname}. I'm working as Software Developer in {Department} Department.");
        }
    }
}
