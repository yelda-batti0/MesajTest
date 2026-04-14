# 💬 MesajTest — C# Windows Forms Mesajlaşma Uygulaması

Basit, veritabanı destekli bir masaüstü mesajlaşma uygulaması. Kullanıcılar numarası ve şifresiyle giriş yaparak gelen/giden mesajlarını görüntüleyebilir ve yeni mesaj gönderebilir.

---

## 📸 Ekran Görüntüleri

<img width="2395" height="1410" alt="Ekran görüntüsü 2026-04-14 224114" src="https://github.com/user-attachments/assets/177b9caf-917c-490d-b9f2-4b8429bbb29f" />
<img width="915" height="355" alt="Ekran görüntüsü 2026-04-14 224020" src="https://github.com/user-attachments/assets/045436ea-2989-49c5-869b-79b6faa85d42" />


| Giriş Ekranı | Ana Ekran |
|---|---|
| Numara ve şifre ile giriş | Gelen kutusu, giden kutusu ve mesaj gönderme |

---

## 🛠️ Kullanılan Teknolojiler

- **Dil:** C# (.NET Framework)
- **Arayüz:** Windows Forms (WinForms)
- **Veritabanı:** Microsoft SQL Server
- **Veri Erişimi:** ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`)

---

## 🗄️ Veritabanı Yapısı

### `TBLKISILER`
| Sütun | Açıklama |
|---|---|
| `NUMARA` | Kullanıcı numarası (giriş kimliği) |
| `SIFRE` | Kullanıcı şifresi |
| `AD` | Kullanıcı adı |
| `SOYAD` | Kullanıcı soyadı |

### `TBLMESAJLAR`
| Sütun | Açıklama |
|---|---|
| `MESAJID` | Mesajın benzersiz kimliği |
| `GONDEREN` | Mesajı gönderen kullanıcı numarası |
| `ALICI` | Mesajı alan kullanıcı numarası |
| `BASLIK` | Mesaj başlığı |
| `ICERIK` | Mesaj içeriği |

---

## 🚀 Kurulum ve Çalıştırma

### Gereksinimler
- Visual Studio 2019 veya üzeri
- Microsoft SQL Server (LocalDB veya tam sürüm)
- .NET Framework 4.x

### Adımlar

1. **Repoyu klonlayın:**
   ```bash
   git clone https://github.com/yelda-batti0/MesajTest.git
   ```

2. **Veritabanını oluşturun:**
   - SQL Server Management Studio'yu açın.
   - `Test` adında yeni bir veritabanı oluşturun.
   - `TBLKISILER` ve `TBLMESAJLAR` tablolarını yukarıdaki yapıya göre oluşturun.
   - Örnek kullanıcı ekleyin:
     ```sql
     INSERT INTO TBLKISILER (NUMARA, SIFRE, AD, SOYAD) VALUES ('1234', '1234', 'AHMET', 'TUNÇ')
     ```

3. **Bağlantı dizesini kontrol edin:**
   - Her iki formda da bağlantı dizesi şu şekilde tanımlı:
     ```
     Data Source=.;Initial Catalog=Test;Integrated Security=True
     ```
   - Sunucu adınız farklıysa `Data Source` değerini güncelleyin.

4. **Projeyi Visual Studio ile açın ve çalıştırın (`F5`).**

---

## ✨ Özellikler

- 🔐 Numara ve şifre doğrulama ile güvenli giriş
- 📥 Gelen kutusunda alınan mesajların listelenmesi
- 📤 Giden kutusunda gönderilen mesajların listelenmesi
- ✉️ Alıcı numarası, başlık ve içerik girerek yeni mesaj gönderme
- 👤 Giriş yapan kullanıcının ad-soyad bilgisinin otomatik gösterimi

---

---

## 👤 Geliştirici

Yelda Battı

> Bu proje, C# ve ADO.NET öğrenimi amacıyla geliştirilmiş örnek bir Windows Forms uygulamasıdır.
