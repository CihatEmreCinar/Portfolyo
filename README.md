-
# MyPortfolioE

**MyPortfolioE** — ASP.NET Core MVC kullanılarak geliştirilmiş kişisel portföy uygulamasıdır. Kullanıcı, kendisi hakkında bilgi girebilir, düzenleyebilir ve frontend'de şık bir şekilde listeleyebilir.

## 🚀 Özellikler

- Hakkımda bölümü (CRUD işlemleri)
- Bootstrap & ready.css ile responsive tasarım
- Entity Framework Core ile veri işlemleri
- Katmanlı mimari (Controller / DAL / Entities)

## 🛠️ Kullanılan Teknolojiler

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap 4
- jQuery, ChartJS (dashboard için)
- ready.css


## 🧪 Nasıl Çalıştırılır?

1. **Proje Dosyasını Aç:** Visual Studio ile `.sln` dosyasını aç.
2. **Veritabanı Ayarları:** `appsettings.json` içerisindeki bağlantı cümlesini (`ConnectionStrings`) kendi SQL Server bilgilerine göre düzenle.
3. **Migration Oluştur:**
   ```bash
   Add-Migration InitialCreate
   Update-Database
   ```
4. **Projeyi Çalıştır:** `F5` ya da `dotnet run`

## 📝 Örnek Kod Parçacığı

**AboutMeController.cs**

public IActionResult Index()
{
    var value = context.Abouts.ToList();
    return View(value);
}
```

## 📌 Geliştirici Notları

- Bootstrap sınıfları responsive yapıyı destekler.
- `@model` tanımı, View ile Controller arasında tip uyumluluğu sağlar.
- Layout sayfası `Views/Layout/Index.cshtml` altında tanımlı.

## 👤 Geliştirici

Emre Çınar

---

```

