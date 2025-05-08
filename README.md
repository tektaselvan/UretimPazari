# Üretim Pazarı

## 📌 Proje Konusu

**Üretim Pazarı**, üretici ve tedarikçi firmaları bir araya getiren bir platformdur. Üreticiler, ürettikleri ürünleri listeleyerek tedarikçilerden teklif toplayabilir; tedarikçiler ise üreticilerin ilanlarına teklif vererek iş birliği sağlayabilir. Bu platform, iki taraf arasındaki ticari işleyişi dijital ortama taşıyarak hızlı, şeffaf ve etkili bir üretim zinciri iletişimi sunar.

## 🚀 Amaç

- Üretici ve tedarikçi firmalar arasında dijital teklifleşme sağlamak.
- Ürün ve kategori bazlı ilanlar oluşturabilmek.
- Kullanıcı ve rol yönetimi ile güvenli erişim kontrolü sunmak.
- Kolay yönetilebilir, sürdürülebilir ve katmanlı bir yazılım mimarisi oluşturmak.

---

## 🧱 Proje Mimarisi

Proje, **katmanlı mimari (Layered Architecture)** kullanılarak geliştirilmiştir:

### 1. **Entities Katmanı**
- Veritabanı tablolarını temsil eden **POCO sınıflar** (Plain Old CLR Objects) içerir.
- Örnek sınıflar: `Product`, `Category`, `Listing`, `Offer`, `Supplier`, `Producer`, `User`, `HomePageContent`, vb.

### 2. **Repositories Katmanı**
- **Veri erişim işlemleri (CRUD)** bu katmanda soyutlanmıştır.
- `RepositoryBase<T>` sınıfı generic olarak temel veri işlemlerini sağlar.
- `ProductRepository`, `CategoryRepository` gibi özel repository sınıfları yer alır.
- `RepositoryManager` ile tüm repository'ler tek noktadan erişilebilir hale gelir.

### 3. **Services Katmanı**
- İş mantığı (business logic) bu katmanda yer alır.
- Her varlık için bir servis arayüzü ve ilgili `Manager` sınıfı bulunur (örneğin: `IProductService` ve `ProductManager`).
- `ServiceManager` ile servisler merkezi şekilde yönetilir.

### 4. **UI (Kullanıcı Arayüzü)**
- Proje bir **Masaüstü uygulaması** veya **MVC Web UI** olarak planlanmıştır. API projesi değildir.
- Controller sınıfları örnekleme amacıyla kullanılabilir.

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji / Araç          | Açıklama |
|---------------------------|----------|
| **.NET 7 / .NET 6**       | Geliştirme platformu |
| **C#**                    | Ana programlama dili |
| **Entity Framework Core** | ORM aracı (Code First yaklaşımı) |
| **MSSQL**                 | Veritabanı |
| **Layered Architecture**  | Temiz kod ve sorumluluk ayrımı |
| **LINQ**                  | Veri sorguları için |
| **Dependency Injection**  | Servis ve repository yönetimi |
| **Visual Studio 2022**    | Geliştirme ortamı |

---

## 📂 Katman Yapısı

```UretimPazariProject/
│
├── UretimPazari.Entities         → Veri modelleri
├── UretimPazari.Repositories     → Veri erişimi ve Repository yapıları
├── UretimPazari.Services         → İş mantığı (Business Layer)
├── UretimPazari.UI               → Kullanıcı arayüzü (MVC/Desktop)
└── README.md                     → Proje açıklaması

---

## ✅ Öne Çıkan Özellikler

- 🧩 Modüler ve genişletilebilir yapı
- 🔐 Veri bütünlüğü için ilişkisel yapı ve foreign key konfigürasyonu
- 📄 Teklif verme, ilan yayınlama ve kategori bazlı filtreleme desteği
- 🔧 Kolay yönetilebilir ve DI destekli servis yapısı

---

## 📎 İleride Eklenebilecek Özellikler

- JWT tabanlı kullanıcı yetkilendirme
- Email bildirim sistemi
- Raporlama modülü (örn. aylık teklif özetleri)
- Çoklu dil desteği (i18n)

---

## 👤 Geliştirici

**Elvan Tektaş**  
Software Developer & Support Specialist  
💼 C#, SQL, Entity Framework, Desktop & Web App    
📫 LinkedIn: [linkedin.com/in/elvantektas](https://www.linkedin.com/in/elvantektas)

---





