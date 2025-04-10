# 📋 .Net Core 6.0 İle Tek Katmanlı Admin Panelli Dinamik Portfolyo Projesine Hoşgeldiniz
Eğitmenliğini Murat Yücedağ'ın üstlendiği ve Udemy Üzerinde 2 Part halinde Ücretsiz olarak yayınladığı "Asp.Net Core ile Admin Panelli Dinamik Bir Portfolyo Geliştirelim" Eğitiminden yararlanarak gerekli tüm caseleri tamamlayarak yaptığım bir projedir

# 📖 Projemin Genel Amacı

Kullanıcının akademik bilgisini paylaşıp, düzenleme yapabilmesi için Admin Paneli bulunan, genel olarak iki farklı tema üzerinden kullanıcının hem CRUD işlemi yapabilmeleri için imkan tanıyan hem de yaptıkları işlemleri Göze hitap eden bir Tema üzerinde listeleyip sunmasını amaçlar.

#  💊 Projede  Kullandığım Teknolojiler
## 📌 Entity Framework Core İle  Veritabanı tablolarını, doğrudan C# sınıfları olarak kullandım.Yani SQL yazmadan veritabanı ile etkileşim kurabildim.
## 📌 UI Tarafını Kod kalabalığını azaltmak için partiallara böldüm bu da kod yükünü azaltarak daha kontrol edilebilir bir yapı elde etmemi sağladı
## 📌 Veri Tabanı tablolarını MS SQL Server üzerinden görüntüledim
## 📌 Hem Veriyi çekip hem de görünüm sağlaması için ViewComponent Kullandım.
## 📌 Asp.Net Core 6.0 Tabanlı bir proje geliştirdim
## 📌 Tek katman üzerinde geliştirmiş olsam da  projede 2 adet katman bulunur;
### 📌Bunlardan biri UI=Kullanıcının gözüne hitap eden katman
### 📌İkincisi ise DataAccessLayer(Veri Erişim Katmanı)= Burada ise EntityFramework'un CodeFirst yapısını kullanarak veri tabanı ile projemin haberleşmesini sağladım

# Gelelim Projedeki Alanların İşlevlerine;
## 📍 Dashboard / Istatistikler
### LINQ sorgularından yararlanarak 12 adet istatistik girdisi sağladım bunlar;
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210248.png)

## 📍 Hakkımda 
### 📌 Kullanıcıların Hakkımda Listesi üzerinde, eklenmiş olan hakkında bilgilerini görebilirler. Ayrıca "Güncelle","Yeni Hakkımda Ekle","Sil" Butonları ile CRUD İşlemleri yapabilirler
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/eb6bd58b306ecaf385e487aaa6fba12ef6ca5361/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20225539.png)
### 📌 Yeni Hakkımda Bilgisi Ekleme Sayfasına Yönelenerek ekleme işlemi yapabilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210307.png)
### 📌 Güncelle Butonu ile ilgili satırdaki verilerin ID Numarasına göre  Hakkımda Güncelleme Sayfasındaki sütunlara ilgili verileri getirerek üzerinde değişiklik yapabilir, Dilerse Sil Butonu İle Direkt Silebilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210312.png)

## 📍Yapılacaklar
### 📌 Kullanıcıların Yapılacaklar Listesi üzerinde, eklenmiş olan yapılacaklar bilgilerini görebilirler. Ayrıca "Güncelle","Yeni Yapılacak Ekle","Sil" Butonları ile CRUD İşlemleri yapabilir, Durum bölümünden durumlarını "Aktif" "Pasif" olarak değiştirebilirler
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/eb6bd58b306ecaf385e487aaa6fba12ef6ca5361/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20225615.png)
### 📌 Yeni Yapılacaklar Bilgisi Ekleme Sayfasına Yönelenerek ekleme işlemi yapabilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210444.png)
### 📌 Güncelle Butonu ile ilgili satırdaki verilerin ID Numarasına göre Yapılacaklar Güncelleme Sayfasındaki sütunlara ilgili verileri getirerek üzerinde değişiklik yapabilir, Dilerse Sil Butonu İle Direkt Silebilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210455.png)


## 📍Deneyimler
### 📌 Kullanıcıların Deneyim Listesi üzerinde, eklenmiş olan deneyim bilgilerini görebilirler. Ayrıca "Güncelle","Yeni Deneyim Ekle","Sil" Butonları ile CRUD İşlemleri yapabilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210505.png)
### 📌 Yeni Deneyim Bilgisi Ekleme Sayfasına Yönelenerek ekleme işlemi yapabilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210555.png)
### 📌 Güncelle Butonu ile ilgili satırdaki verilerin ID Numarasına göre Deneyim Güncelleme Sayfasındaki sütunlara ilgili verileri getirerek üzerinde değişiklik yapabilir, Dilerse Sil Butonu İle Direkt Silebilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210706.png)


## 📍 Öne Çıkanlar
### 📌 Kullanıcıların Deneyim Listesi üzerinde, eklenmiş olan öne çıkan bilgilerini görebilirler. Ayrıca "Güncelle","Yeni Öne Çıkan Ekle","Sil" Butonları ile CRUD İşlemleri yapabilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/eb6bd58b306ecaf385e487aaa6fba12ef6ca5361/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20225642.png)
### 📌 Yeni Öne Çıkan Bilgisi Ekleme Sayfasına Yönelenerek ekleme işlemi yapabilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210842.png)
### 📌 Güncelle Butonu ile ilgili satırdaki verilerin ID Numarasına göre Öne Çıkan Güncelleme Sayfasındaki sütunlara ilgili verileri getirerek üzerinde değişiklik yapabilir, Dilerse Sil Butonu İle Direkt Silebilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210847.png)


## 📍 İletişim Bilgileri
### 📌 Kullanıcıların İletişim Bilgileri Listesi üzerinde, eklenmiş olan İletişim bilgilerini görebilirler. Ayrıca "Güncelle","Yeni İletişim Bilgisi Ekle","Sil" Butonları ile CRUD İşlemleri yapabilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210855.png)
### 📌 Yeni İletişim Bilgileri Ekleme Sayfasına Yönelenerek ekleme işlemi yapabilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210900.png)
### 📌 Güncelle Butonu ile ilgili satırdaki verilerin ID Numarasına göre İletişim Bilgileri Güncelleme Sayfasındaki sütunlara ilgili verileri getirerek üzerinde değişiklik yapabilir, Dilerse Sil Butonu İle Direkt Silebilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20210931.png)



## 📍 Portfolyo
### 📌 Kullanıcıların Portfolyo Bilgileri Listesi üzerinde, eklenmiş olan İletişim bilgilerini görebilirler. Ayrıca "Güncelle","Yeni Portfolyo Ekle","Sil" Butonları ile CRUD İşlemleri yapabilir
### 📌 Yeni Portfolyo Bilgileri Ekleme Sayfasına Yönelenerek ekleme işlemi yapabilir
### 📌 Güncelle Butonu ile ilgili satırdaki verilerin ID Numarasına göre Portfolyo Bilgileri Güncelleme Sayfasındaki sütunlara ilgili verileri getirerek üzerinde değişiklik yapabilir, Dilerse Sil Butonu İle Direkt Silebilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211014.png)
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211019.png)
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211026.png)


## 📍Yetenekler
### 📌 Kullanıcıların Yetenek Bilgileri Listesi üzerinde, eklenmiş olan Yetenek bilgilerini görebilirler. Ayrıca "Güncelle","Yeni Yetenek Ekle","Sil" Butonları ile CRUD İşlemleri yapabilir
### 📌 Yeni Yetenek Bilgileri Ekleme Sayfasına Yönelenerek ekleme işlemi yapabilir
### 📌 Güncelle Butonu ile ilgili satırdaki verilerin ID Numarasına göre Yetenek Bilgileri Güncelleme Sayfasındaki sütunlara ilgili verileri getirerek üzerinde değişiklik yapabilir, Dilerse Sil Butonu İle Direkt Silebilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211034.png)
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211044.png)
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211050.png)


## 📍 Referanslar
### 📌 Kullanıcıların Referans Bilgileri Listesi üzerinde, eklenmiş olan Referans bilgilerini görebilirler. Ayrıca "Güncelle","Yeni Referans Ekle","Sil" Butonları ile CRUD İşlemleri yapabilir
### 📌 Yeni Referans Bilgileri Ekleme Sayfasına Yönelenerek ekleme işlemi yapabilir
### 📌 Güncelle Butonu ile ilgili satırdaki verilerin ID Numarasına göre Referans Bilgileri Güncelleme Sayfasındaki sütunlara ilgili verileri getirerek üzerinde değişiklik yapabilir, Dilerse Sil Butonu İle Direkt Silebilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211058.png)
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211103.png)
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211109.png)


## 📍 Sosyal Medya
### 📌 Kullanıcıların Sosyal Medya Bilgileri Listesi üzerinde, eklenmiş olan Sosyal Medya bilgilerini görebilirler. Ayrıca "Güncelle","Yeni Sosyal Medya Ekle","Sil" Butonları ile CRUD İşlemleri yapabilir
### 📌 Yeni Sosyal MedyaBilgileri Ekleme Sayfasına Yönelenerek ekleme işlemi yapabilir
### 📌 Güncelle Butonu ile ilgili satırdaki verilerin ID Numarasına göre Sosyal Medya Bilgileri Güncelleme Sayfasındaki sütunlara ilgili verileri getirerek üzerinde değişiklik yapabilir, Dilerse Sil Butonu İle Direkt Silebilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211116.png)
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211123.png)
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211129.png)



##📍 Gelen Kutusu
### 📌 Kullanıcıların Taraflarına gelen mesajları burada görüntüleyebilir, 
### 📌 Yeni Sosyal MedyaBilgileri Ekleme Sayfasına Yönelenerek ekleme işlemi yapabilir,dilerse mesajların okundu durumunu "Okundu Olarak İşaretle" "Okunmadı Olarak İşaretle" olarka değiştirebilirler, "Mesajı Aç" butonu ile de mesaj detayını ulaşabilirler.
### 📌 Güncelle Butonu ile ilgili satırdaki verilerin ID Numarasına göre Sosyal Medya Bilgileri Güncelleme Sayfasındaki sütunlara ilgili verileri getirerek üzerinde değişiklik yapabilir, Dilerse Sil Butonu İle Direkt Silebilir
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211149.png)
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211205.png)






# UI Tarafındaki Görseller ise;
![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/1afa91eee2cebdc8ff3253a28813e310daa326f4/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20230452.png)

![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211231.png)

![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211239.png)

![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211249.png)

![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211300.png)

![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211318.png)

![ImageAlt](https://github.com/SemihSanli/Core6.0_Portfolio/blob/10c0055ed04b47443cf43f37c3831f119bca65dd/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-10%20211324.png)

