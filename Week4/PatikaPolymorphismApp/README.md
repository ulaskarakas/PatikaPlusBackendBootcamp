# Patika - Polymorphism App

PatikaPolymorphismApp is a simple yet effective demonstration of object-oriented programming principles, specifically focusing on polymorphism. By utilizing a base class and derived classes, the application calculates areas for various geometric shapes, showcasing how polymorphism can simplify and unify method implementations.

## Project Purpose

This project demonstrates the concept of polymorphism through a simple example. It includes a base class for geometric shapes and derived classes for specific shapes, each implementing their own method for calculating area. Polymorphism allows these different implementations to be used seamlessly.

---

## Application Features

- **Polymorphism Implementation**: Demonstrates the use of polymorphism with a base class and derived classes.
- **Geometric Shape Calculations**: Includes classes for Square, Rectangle, and Right Triangle, each with its own area calculation logic.
- **Dynamic Method Invocation**: Uses overridden methods to calculate areas dynamically at runtime.
- **Console Output**: Displays the calculated areas for each shape directly in the console.

---

## Code Description
The project includes the following classes:

### 1. BaseGeometricShape (Base Geometric Shape Class)
- **Properties**:
  - `Width`: The width of the shape.
  - `Height`: The height of the shape.
- **Methods**:
  - `CalculateArea()`: A base method for calculating the area of the shape. Derived classes override this method to provide specific implementations.

### 2. Square Class
- **Constructor**:
  - Accepts the width (`Width`) and uses it for the square.
- **Methods**:
  - `CalculateArea()`: Calculates the area of the square (`Width * Width`) and prints it to the console.

### 3. Rectangle Class
- **Constructor**:
  - Accepts the width (`Width`) and height (`Height`) values.
- **Methods**:
  - `CalculateArea()`: Calculates the area of the rectangle (`Width * Height`) and prints it to the console.

### 4. RightTriangle Class
- **Constructor**:
  - Accepts the width (`Width`) and height (`Height`) values.
- **Methods**:
  - `CalculateArea()`: Calculates the area of the right triangle (`(Width * Height) / 2`) and prints it to the console.

### Program.cs
These classes are utilized in the `Main` method of the `Program` class. Example usage:
```csharp
BaseGeometricShape shapeSquare = new Square(5);
BaseGeometricShape shapeRectangle = new Rectangle(5, 3);
BaseGeometricShape shapeRightTriangle = new RightTriangle(5, 12);

shapeSquare.CalculateArea();
shapeRectangle.CalculateArea();
shapeRightTriangle.CalculateArea();
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
   git clone https://github.com/ulaskarakas/PatikaPolymorphismApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaPolymorphismApp
   dotnet run
   ```

---

## Example Output

```
Area: 25
Area: 15
Area: 30
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
