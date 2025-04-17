using PatikaInheritanceApp;

public class Program
{
    public static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Orhan", "Akın", 50000);
        Student student = new Student("Ahmet", "Ekim", 253496);

        teacher.Introduce();
        student.Introduce();

    }
}


