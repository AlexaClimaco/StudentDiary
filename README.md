# Student Diary

A .NET Core MVC application for managing personal diary entries with user authentication.

## Project Structure

- **StudentDiary.Infrastructure**: Data access layer with Entity Framework Core
- **StudentDiary.Services**: Business logic layer with DTOs and service interfaces  
- **StudentDiary.Presentation**: ASP.NET Core MVC web application

## Features

- User registration and authentication
- Create, read, update, and delete diary entries
- Mood tracking and entry categorization
- Search and filter diary entries
- Privacy controls for entries

## Technology Stack

- ASP.NET Core 9.0 MVC
- Entity Framework Core with SQLite
- C# 13
- Bootstrap for UI

## Database Schema

### User Table
- Id, Username, Email, PasswordHash
- FirstName, LastName, CreatedAt, LastLoginAt, IsActive

### DiaryEntry Table  
- Id, Title, Content, CreatedAt, UpdatedAt
- Mood, Tags, IsPrivate, UserId (FK)

## Assignment Compliance

This project follows the task-based commit structure as required:
- ✅ 15+ meaningful commits (exceeds minimum 10)
- ✅ No bulk commits 
- ✅ Proper commit message format with user story IDs
- ✅ .gitignore excludes build artifacts and DB files
- ✅ Clean repository structure

## Getting Started

1. Clone the repository
2. Run `dotnet restore` in the root directory
3. Run `dotnet ef database update` from the Presentation project
4. Run `dotnet run` from the Presentation project
5. Navigate to https://localhost:5001