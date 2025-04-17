# Patika - Code First Basic API
This project is a simple Code-First approach API built using ASP.NET Core Web API and Entity Framework Core. It includes two main entities: Movie and Game.

## 🚀 Project Purpose
The purpose of this project is to demonstrate how to implement a Code-First approach with Entity Framework Core in an ASP.NET Core Web API. It provides basic CRUD operations for managing Movies and Games in a SQL Server database. The project also serves as an educational resource for understanding DbContext, Migrations, and API Development with Swagger support.

## 🎯 Features
- Code-First Approach using Entity Framework Core
- SQL Server Integration with Windows Authentication
- Data Migrations using EF Core Migrations
- Modular and Scalable Architecture

## 🗄️ Entities
### 🎬 Movie
```bash
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
}
```
### 🎮 Game
```bash
public class Game
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Platform { get; set; }
    public decimal Rating { get; set; }
}
```

## 📊 DbContext Configuration
```bash
public class PatikaFirstDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Game> Games { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=PatikaCodeFirstDb1; Trusted_Connection=true; TrustServerCertificate=True");
    }
}
```

## 🛠️ Technologies Used
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (Windows Authentication)

## 🏗️ Installation and Execution

Follow these steps to run the application:

1. **Clone the project:**
   ```bash
   git clone https://github.com/ulaskarakas/PatikaFirstCodeBasicAPI.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaFirstCodeBasicAPI
   ```
4. **Install Dependencies:**
   ```bash
   dotnet restore
   ```
5. **Update the Database:**
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
6. **Run the Application:**
   ```bash
   dotnet run
   ```

## 🤝 Contributing
To contribute to this project, please submit a **Pull Request** or create an **Issue**.

## ⚖️ License
This project is licensed under the MIT License.

## 📬 Contact
For any questions or suggestions, feel free to contact me:

[![Gmail](https://ziadoua.github.io/m3-Markdown-Badges/badges/Gmail/gmail1.svg)](mailto:ulaskarakas95@gmail.com)
[![LinkedIn](https://ziadoua.github.io/m3-Markdown-Badges/badges/LinkedIn/linkedin1.svg)](https://www.linkedin.com/in/ulas-karakas/)
