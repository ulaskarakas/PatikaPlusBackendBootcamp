# Patika - Crazy Musicians API

This API allows users to manage a collection of musicians with their details.

## 🚀 Project Purpose
The Patika Crazy Musicians API is designed to offer an easy and efficient way to manage musician-related data. The API enables users to store, retrieve, update, and delete information about musicians. It is primarily intended for:
- Developers building music-related applications.
- Students learning about RESTful API development.
- Anyone looking for a practical example of CRUD operations in ASP.NET Core.

## 🎯 Features
- ✅ **CRUD operations:** Create, Read, Update, and Delete musician records efficiently.
- 🔍 **Search functionality:** Allows filtering musicians by name for quick lookups.
- 🔒 **Data validation:** Ensures required fields are properly populated to maintain data integrity.
- 📖 **Swagger integration:** Provides interactive API documentation and testing via Swagger UI.
- 🔗 **RESTful architecture:** Implements RESTful principles for scalable and easy-to-integrate endpoints.

## 🛠️ Technologies Used
- ASP.NET Core Web API
- C#
- .NET 8+
- Swagger for API Documentation

## 🔗 Endpoints

### 🟢 Get All Musicians
- **Endpoint:** `GET /api/musicians`
- **Description:** Returns a list of all musicians.
- **Response:**
```json
[
    {
        "id": 1,
        "fullName": "Ahmet Çalgı",
        "profession": "Famous Instrument Player",
        "funnyProperty": "Always plays the wrong note, but it's so much fun"
    }
]
```

### 🟢 Get Musician by ID
- **Endpoint:** `GET /api/musicians/{id}`
- **Description:** Retrieves a musician by their ID.
- **Response:**
```json
{
    "id": 1,
    "fullName": "Ahmet Çalgı",
    "profession": "Famous Instrument Player",
    "funnyProperty": "Always plays the wrong note, but it's so much fun"
}
```

### 🔍 Search for a Musician by Name
- **Endpoint:** `GET /api/musicians/search?fullName={name}`
- **Description:** Searches for musicians whose names contain the given keyword.
- **Response:**
```json
[
    {
        "id": 7,
        "fullName": "Ali Perde",
        "profession": "Fret Applicator",
        "funnyProperty": "Plays every fret differently, always surprising"
    }
]
```

### 🟢 Create a Musician
- **Endpoint:** `POST /api/musicians`
- **Description:** Adds a new musician.
- **Request Body:**
```json
{
    "fullName": "Jane Doe",
    "profession": "Drummer",
    "funnyProperty": "Plays drums with chopsticks."
}
```
- **Response:**
```json
{
    "id": 2,
    "fullName": "Jane Doe",
    "profession": "Drummer",
    "funnyProperty": "Plays drums with chopsticks."
}
```

### 🟡 Update Musician (PUT)
- **Endpoint:** `PUT /api/musicians/{id}`
- **Description:** Updates all musician details.
- **Request Body:**
```json
{
    "fullName": "John Doe",
    "profession": "Pianist",
    "funnyProperty": "Plays piano with one hand."
}
```
- **Response:** `204 No Content`

### 🟡 Update Musician's Name (PATCH)
- **Endpoint:** `PATCH /api/musicians/{id}`
- **Description:** Updates only the musician's full name.
- **Request Body:**
```json
"New Full Name"
```
- **Response:** `204 No Content`

### 🔴 Delete a Musician
- **Endpoint:** `DELETE /api/musicians/{id}`
- **Description:** Deletes a musician by ID.
- **Response:** `204 No Content`

## Notes
- Validation is implemented for required fields.
- `PATCH` is used for updating only the musician's name.
- `DELETE` removes a musician from the list permanently.
- API uses **Swagger** for testing endpoints.

## 🏗️ Installation and Execution

Follow these steps to run the application:

1. **Clone the project:**
   ```bash
   git clone https://github.com/ulaskarakas/PatikaCrazyMusiciansAPI.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaCrazyMusiciansAPI
   dotnet run
   ```

📝 Notes

- ✅ Validation is implemented for required fields.
- 🛠 PATCH is used for updating only the musician's name.
- 🗑 DELETE removes a musician from the list permanently.
- 📖 API uses Swagger for testing endpoints.

## 🤝 Contributing
To contribute to this project, please submit a **Pull Request** or create an **Issue**.

## ⚖️ License
This project is licensed under the MIT License.

## 📬 Contact
For any questions or suggestions, feel free to contact me:

[![Gmail](https://ziadoua.github.io/m3-Markdown-Badges/badges/Gmail/gmail1.svg)](mailto:ulaskarakas95@gmail.com)
[![LinkedIn](https://ziadoua.github.io/m3-Markdown-Badges/badges/LinkedIn/linkedin1.svg)](https://www.linkedin.com/in/ulas-karakas/)
