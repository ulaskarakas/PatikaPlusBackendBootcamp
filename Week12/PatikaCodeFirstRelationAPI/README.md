# Patika - Code First Relation API
This project is a Code-First approach API built using ASP.NET Core Web API and Entity Framework Core. It demonstrates how to establish relationships between entities in a database using one-to-many (1:M) relationships.

## 🚀 Project Purpose
The purpose of this project is to showcase how to implement entity relationships using Entity Framework Core in an ASP.NET Core Web API. The project manages Users and their Posts, illustrating how to handle one-to-many relationships, foreign keys, and cascading delete operations.

## 🎯 Features
- Code-First Approach using Entity Framework Core
- One-to-Many Relationship between Users and Posts
- SQL Server Integration with Windows Authentication
- Data Migrations using EF Core Migrations

## 🗄️ Entities
### 🎬 User
```bash
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }

    public List<Post> Posts { get; set; }

}
```
### 🎮 Post
```bash
public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}
```

## 📊 DbContext Configuration
```bash
public class PatikaSecondDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }

    public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=PatikaCodeFirstDb2; Trusted_Connection = true; TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("Users");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Username).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(50);

            entity.HasMany(e => e.Posts)
                  .WithOne(e => e.User)
                  .HasForeignKey(e => e.UserId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.ToTable("Posts");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired().HasMaxLength(50);
            entity.Property(e => e.Content).IsRequired().HasMaxLength(500);
        });
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
   git clone https://github.com/ulaskarakas/PatikaFirstCodeRelationAPI.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaFirstCodeRelationAPI
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
