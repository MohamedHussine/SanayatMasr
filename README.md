# 🛠️ صنايعية مصر - Sanaie’ya Masr
### ITI Graduation Project | .NET Backend Developer

**صنايعية مصر** هي منصة تهدف لربط المستخدمين بأفضل الحرفيين (الصنايعية) في جميع محافظات مصر. يتيح النظام للمستخدم البحث عن حرفي، تقييمه، وتقديم طلبات صيانة بكل سهولة وضمان.

---

## 📸 Project Screenshots
<p align="center">
  <img src="screencapture-localhost-4200-home-2026-01-02-13_31_22.jpg" width="80%" alt="Main Page">
</p>

<p align="center">
  <img src="link-to-your-second-image.jpg" width="45%" />
  <img src="link-to-your-third-image.jpg" width="45%" />
</p>

---

## 🏗️ Architecture & Design Patterns
المشروع مبني باتباع أفضل المعايير البرمجية لضمان سهولة التوسع (Scalability) والنظافة (Clean Code):
* **N-tier Architecture:** فصل طبقات المشروع (API, Business Logic, Data Access).
* **SOLID Principles:** تطبيق المبادئ الخمسة لكتابة كود مرن وقابل للاختبار.
* **Repository Pattern:** (إذ تم استخدامه) لعزل منطق التعامل مع قاعدة البيانات.

---

## 🚀 Built With (Tech Stack)

### **Core Technologies**
* **Framework:** ASP.NET Core Web API
* **Database:** SQL Server
* **ORM:** Entity Framework Core

### **Key Packages**
| Package | Purpose |
| :--- | :--- |
| **AutoMapper** | Mapping between Entities and DTOs |
| **Cloudinary.net** | Image uploading and cloud storage |
| **FluentValidation** | Robust input validation rules |
| **Identity** | Authentication and Authorization (JWT) |
| **Swagger** | API Documentation & Testing |
| **EF Tools/Design** | Database migrations and management |

---

## 🛠️ Features
- [x] **Search:** البحث بالصنايعي أو المحافظة أو الخدمة.
- [x] **Rating System:** تقييم الصنايعية بناءً على تجربة المستخدم.
- [x] **User Management:** نظام كامل لتسجيل الدخول وحماية البيانات (Identity).
- [x] **Service Requests:** إرسال طلبات صيانة مباشرة للصنايعي.
- [x] **Media:** رفع صور الأعمال والملفات الشخصية عبر Cloudinary.

---

## ⚙️ How to Run
1. قم بتحميل المشروع (Clone):
   ```bash
   git clone [https://github.com/YOUR_USERNAME/Sanaieya-Masr.git](https://github.com/YOUR_USERNAME/Sanaieya-Masr.git)
