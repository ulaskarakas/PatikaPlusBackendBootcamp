using PatikaDependencyInjection.Services;
using System;
namespace PatikaDependencyInjection.Managers
{
    internal class TeacherManager : ITeacherService
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public TeacherManager(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInfo()
        {
            return $"Öğretmen: {FirstName} {LastName}";
        }
    }
}
