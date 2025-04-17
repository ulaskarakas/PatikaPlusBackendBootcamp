using PatikaDependencyInjection.Managers;
using PatikaDependencyInjection.Services;

class Program
{
    static void Main()
    {
        // Dependency Injection ile sınıfı oluşturuyoruz.
        ITeacherService teacher = new TeacherManager("Ekrem", "Yılmaz");
        ClassroomManager classRoom = new ClassroomManager(teacher);

        // Öğretmen bilgilerini yazdır
        classRoom.GetTeacherInfo();
    }
}