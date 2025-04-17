using PatikaDependencyInjection.Services;

namespace PatikaDependencyInjection.Managers
{
    internal class ClassroomManager
    {
        private readonly ITeacherService _teacher;

        public ClassroomManager(ITeacherService teacher)
        {
            _teacher = teacher;
        }

        public void GetTeacherInfo()
        {
            Console.WriteLine(_teacher.GetInfo());
        }
    }
}
