using PatikaLinqGroupJoinApp;

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        students.Add(new Student { StudentId = 1, StudentName = "Ali", CourseId = 1});
        students.Add(new Student { StudentId = 2, StudentName = "Ayşe", CourseId = 2 });
        students.Add(new Student { StudentId = 3, StudentName = "Mehmet", CourseId = 1 });
        students.Add(new Student { StudentId = 4, StudentName = "Fatma", CourseId = 3 });
        students.Add(new Student { StudentId = 5, StudentName = "Ahmet", CourseId = 2 });

        List<Course> courses = new List<Course>();
        courses.Add(new Course { CourseId = 1, CourseName = "Matematik" });
        courses.Add(new Course { CourseId = 2, CourseName = "Türkçe" });
        courses.Add(new Course { CourseId = 3, CourseName = "Kimya" });

        var mergedStudentsAndCourses = courses.GroupJoin(students,
                                                          course => course.CourseId,
                                                          student => student.CourseId,
                                                          (course, student) => new
                                                          {
                                                              CourseName = course.CourseName,
                                                              students = students.ToList(),
                                                          });

        foreach (var course in mergedStudentsAndCourses)
        {
            Console.WriteLine(course.CourseName);
            foreach (var student in students)
            {
                Console.WriteLine($" {student.StudentName}");
            }
        }

    }
}