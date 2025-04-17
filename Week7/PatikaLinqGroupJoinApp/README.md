# Patika - Linq Group Join App

This project demonstrates the use of the `GroupJoin` LINQ method to combine two collections (`students` and `courses`) based on a common property (`CourseId`). The example simulates a simple scenario where students are enrolled in different courses.

## Project Purpose

The purpose of this project is to showcase the practical use of LINQ's `GroupJoin` method to group and join data from two different collections. This is particularly useful when dealing with related data (such as students and courses) and needing to present it in a structured format. The example helps understand how to group items based on a common key and display the results in a readable way.

---

## Application Features

- **GroupJoin**: Demonstrates the LINQ `GroupJoin` method to group and join data.
- **Simple Data Example**: Uses simple collections of students and courses to showcase the join.
- **Console Output**: Outputs the result in a clear, readable format showing each course with its enrolled students.
- **Real-World Simulation**: Simulates a real-world scenario of students being enrolled in courses.

---

## Project Structure

- `Program.cs`: Main program entry point
- `Student.cs`: Defines the Student class with properties (StudentId, StudentName, CourseId)
- `Course.cs`: Defines the Course class with properties (CourseId, CourseName)

---

## Code Example

### Program.cs
```csharp
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
```

### Student.cs
```csharp
namespace PatikaLinqGroupJoinApp
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int CourseId { get; set; }
    }
}
```

### Course.cs
```csharp
namespace PatikaLinqGroupJoinApp
{
    public class Course
    {
        public string CourseName { get; set; }
        public int CourseId { get; set; }
        
    }
}
```

---

## Technologies Used

- **C#**: Programming language used for development.
- **.NET Core**: Framework for project execution.

---

## Installation and Execution

Follow these steps to run the application:

1. **Clone the project:**
   ```bash
   git clone https://github.com/ulaskarakas/PatikaLinqGroupJoinApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaLinqGroupJoinApp
   dotnet run
   ```

---

## Contributing
To contribute to this project, please submit a **Pull Request** or create an **Issue**.

---

## License
This project is licensed under the MIT License.

---

## Contact
For any questions or suggestions, feel free to contact me:
- **Email**: [ulaskarakas95@gmail.com](mailto:ulaskarakas95@gmail.com)
- **LinkedIn**: [Ulaş Karakaş](https://www.linkedin.com/in/ulas-karakas/)

