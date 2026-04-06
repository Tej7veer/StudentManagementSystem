# Student Management System — ASP.NET Core 8 Web API

## Tech Stack
- ASP.NET Core 8, EF Core, SQL Server
- JWT Authentication, Serilog, Swagger

## Setup Steps
1. Run `Script.sql` in SQL Server Management Studio
2. Update connection string in `appsettings.json`:
   `Server=.;Database=StudentManagementDb;Trusted_Connection=True;TrustServerCertificate=True;`
3. Run: `dotnet run`
4. Open Swagger: `https://localhost:5001/swagger`

## Login
POST `/api/auth/login`
```json
{ "username": "admin", "password": "admin123" }
```
Copy the token → click **Authorize** in Swagger → enter `Bearer <token>`

## API Endpoints
| Method | Endpoint | Auth |
|--------|----------|------|
| POST | /api/auth/login | Public |
| GET | /api/students | JWT |
| GET | /api/students/{id} | JWT |
| POST | /api/students | JWT |
| PUT | /api/students/{id} | JWT |
| DELETE | /api/students/{id} | JWT |

## UI Repo
https://github.com/Tej7veer/StudentManagementUI
