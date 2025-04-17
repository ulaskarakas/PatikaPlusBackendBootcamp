# Patika - Switch Case App

This application is a simple console program that displays the price of the selected fruit based on the user's input. The project is developed in **C#** and demonstrates the use of the **switch-case** structure.


## Project Purpose

The main purpose of this project is to provide a practical example of using the switch-case structure in C#. It aims to teach basic programming concepts such as user input handling, control flow, and console application development in a simple and engaging way.

---

## Application Features
1. Takes fruit selection input from the user.
2. Displays the price of the selected fruit.
3. Case-insensitive input handling.
4. Notifies the user in case of invalid input and prompts for a valid selection.

---

## Technologies Used
- **C#**: Programming language used for development.
- **.NET Core**: Framework for project execution.

---

## Installation and Execution
Follow these steps to run the application:

1. **Clone the project:**
   ```bash
   git clone https://github.com/ulaskarakas/PatikaSwitchCaseApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaSwitchCaseApp
   dotnet run
   ```

---

## How It Works

1. When the program starts, it asks the user which fruit they want to buy.
2. The user must input one of the following options:
   - Apple
   - Pear
   - Strawberry
   - Banana
   - Other
3. Upon a valid selection, the price of the selected fruit is displayed.
4. If the input is invalid, the user is notified and prompted to enter a valid option.

### Fruit Prices

| Fruit    | Price (TL) |
|----------|------------|
| Apple    | 2          |
| Pear     | 3          |
| Strawberry | 2        |
| Banana   | 3          |
| Other    | 4          |

### Highlights in the Code

- User inputs are converted to lowercase using the `ToLower()` method to eliminate case sensitivity.
- The `switch-case` structure is used to make the code more readable and maintainable.

---

## Example Usage

![image](https://github.com/user-attachments/assets/4f3a8d67-0965-427f-af39-f5c0082d2e50)

---

## Developer Notes

- Instead of **if-else**, the **switch-case** structure was used to make the code cleaner and more understandable.
- In the future, a feature to dynamically set fruit prices can be added.

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
