# 🎧 Evento Backend

This is the backend API for **Evento**, a full-stack social platform for sharing and tracking live music experiences.

Built with:
- ASP.NET Core 8 Web API
- PostgreSQL (via Railway)
- JWT Authentication (planned)
- Docker-ready for deployment

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- PostgreSQL database (e.g. Railway or local)
- (Optional) [Docker](https://www.docker.com/) for containerization

### Run Locally

```bash
cd backend
dotnet run
API will be available at:
http://localhost:5087/api/hello
```

📁 Project Structure
bash
Copy
Edit
backend/
├── Controllers/       # API route handlers
├── Models/            # Data models & DTOs (planned)
├── Services/          # Business logic (planned)
├── Program.cs         # App startup
├── appsettings.json   # Config and connection strings
🔧 Development Roadmap
 Health check / hello world

 Connect to PostgreSQL

 User & Event models

 JWT-based Auth (login/register)

 Cloudinary image upload

 Rate limiting & caching (Redis)

 Dockerfile + Railway deployment

📦 Deployment
This backend will be deployed to Railway as a Docker container.
