using System;

namespace PatikaCreateFirstClassApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person studentOne = new Person();
            studentOne.Name = "Mehmet";
            studentOne.Surname = "Akyüz";
            studentOne.BirthDate = new DateTime(1994, 12, 15);

            Person studentTwo = new Person();
            studentTwo.Name = "Ahmet";
            studentTwo.Surname = "Ekim";
            studentTwo.BirthDate = new DateTime(1995, 2, 3);

            Person teacherOne = new Person();
            teacherOne.Name = "Murat";
            teacherOne.Surname = "Akın";
            teacherOne.BirthDate = new DateTime(1985, 8, 30);

            Person teacherTwo = new Person();
            teacherTwo.Name = "Kerem";
            teacherTwo.Surname = "Solmaz";
            teacherTwo.BirthDate = new DateTime(1988, 4, 12);

            Console.Write($"Birinci ögrencinin ");
            studentOne.DisplayPerson(studentOne.Name, studentOne.Surname, studentOne.BirthDate);

            Console.Write($"İkinci ögrencinin ");
            studentTwo.DisplayPerson(studentTwo.Name, studentTwo.Surname, studentTwo.BirthDate);

            Console.Write($"Birinci ögretmenin ");
            teacherOne.DisplayPerson(teacherOne.Name, teacherOne.Surname, teacherOne.BirthDate);

            Console.Write($"İkinci ögretmenin ");
            teacherTwo.DisplayPerson(teacherTwo.Name, teacherTwo.Surname, teacherTwo.BirthDate);

        }
    }
}