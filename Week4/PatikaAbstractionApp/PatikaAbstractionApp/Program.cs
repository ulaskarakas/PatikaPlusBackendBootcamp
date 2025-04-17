using PatikaAbstractionApp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("** Abstraction with Interface **");
        IEmployee softwareDeveloper = new SoftwareDeveloper("Ahmet", "Ekim", "Sofware");
        IEmployee projectManager = new ProjectManager("Cengiz", "Erden", "Sofware");
        IEmployee salesRepresentative = new SalesRepresentative("Ümit", "Avcı", "Sales");

        softwareDeveloper.Task();
        projectManager.Task();
        salesRepresentative.Task();

        Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

        Console.WriteLine("** Abstraction with Abstract Class **");

        Employee softwareDeveloperWithClass = new SoftwareDeveloperWithClass("Ahmet", "Ekim", "Sofware");
        Employee projectManagerWithClass = new ProjectManagerWithClass("Cengiz", "Erden", "Sofware");
        Employee salesRepresentativeWithClass = new SalesRepresentativeWithClass("Ümit", "Avcı", "Sales");

        softwareDeveloperWithClass.Task();
        projectManagerWithClass.Task();
        salesRepresentativeWithClass.Task();

    }
}