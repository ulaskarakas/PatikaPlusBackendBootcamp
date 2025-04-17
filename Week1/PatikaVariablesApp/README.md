# Patika - Variables App

Patika - Variables App is a simple console application developed in C#. It collects various personal details and the prices of two products purchased by the user, calculates the total price, and determines the amount of "Patika Puan" earned based on the total price.

## Project Purpose
This project was created to reinforce fundamental C# concepts such as variable usage, data types, user input handling, conditional statements, and loops.

---

## Application Features
1. Collects the following information from the user:
   - ID Number
   - First and Last Name
   - Phone Number
   - Age
   - Price of the first product
   - Price of the second product

2. Validates whether the product prices are valid numbers.
3. Calculates the total price.
4. Computes "Patika Puan" as 10% of the total price.
5. Displays the user's details and the calculated points.

---

## Technologies Used
- **C#**: Programming language used for development.
- **.NET Core**: Framework for project execution.

---

## Installation and Execution
Follow these steps to run the application:

1. **Clone the project:**
   ```bash
   git clone https://github.com/ulaskarakas/PatikaVariablesApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaVariablesApp
   dotnet run
   ```
   
---

## Usage
When the application is run, the console will display the following flow:

![PatikaVariablesApp](https://github.com/user-attachments/assets/054a3fef-9446-4e57-b421-1ad30b0388a6)

---
## Code Explanations
- **Variables**: User input is stored as strings since no arithmetic operations are performed on them.
- **TryParse Usage**: Product prices are taken as strings and converted to integers using the `int.TryParse` method.
- **Conditional Loop**: Ensures the user enters a valid number; otherwise, an error message is displayed.
- **Point Calculation**: 10% of the total expenditure is calculated as "Patika Puan".

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
