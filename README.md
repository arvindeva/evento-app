# 🎶 Evento

A full-stack social platform to track and relive your concert experiences.

## 🧱 Stack

- **Frontend**: Next.js (Tailwind CSS, deployed on Vercel)
- **Backend**: .NET Core Web API (deployed with Docker to Railway)
- **Database**: PostgreSQL (Railway)
- **Image Upload**: Cloudinary (client-side uploads)
- **Auth**: JWT + Refresh Token (secure cookie)
- **Deployment**: Monorepo with Docker, Vercel, and Railway

---

## 📁 Project Structure

evento-app/
├── frontend/ → Next.js app
├── backend/ → .NET Core Web API (soon)
├── infra/ → Deployment config (Docker, scripts)
└── README.md

---

## 🛠️ Getting Started

### Frontend

```bash
cd frontend
npm install
npm run dev