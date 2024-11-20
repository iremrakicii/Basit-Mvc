CustomerOrders Projesi
Bu proje, bir müşteriye ait temel bilgileri ve müşterinin siparişlerini listeleyen bir ASP.NET Core MVC uygulamasıdır. Projede bir müşteri ve sipariş verileri örnek olarak oluşturulmuş ve bu veriler bir ViewModel kullanılarak View'da görüntülenmiştir.

Proje Yapısı
Modeller
Customer (Müşteri Modeli)

Müşteri bilgilerini temsil eder.
Özellikler:
Id: Müşterinin kimlik numarası.
FirstName: Müşteri adı.
LastName: Müşteri soyadı.
Email: Müşteri e-posta adresi.
Order (Sipariş Modeli)

Müşterinin siparişlerini temsil eder.
Özellikler:
Id: Sipariş kimliği.
ProductName: Ürün adı.
Price: Ürün birim fiyatı.
Quantity: Sipariş miktarı.
CustomerOrderViewModel

Müşteri ve sipariş bilgilerini bir arada taşır.
Özellikler:
Customer: Müşteri bilgisi.
Orders: Sipariş listesi.
Controller
CustomerOrdersController

Index metodu, müşteri ve sipariş örneklerini oluşturur ve CustomerOrderViewModel ile View'a gönderir.
View
Index.cshtml

Müşteri bilgilerini ve sipariş listesini bir tablo içerisinde görüntüler.
Genel toplam fiyatı hesaplar ve görüntüler.
Tablo sütunları:
Ürün Adı
Birim Fiyat
Miktar
Toplam Tutar (Birim Fiyat x Miktar)
Kullanım
Projeyi Çalıştırma

Proje, bir ASP.NET Core MVC projesi olarak tasarlanmıştır. Projeyi çalıştırmak için Visual Studio veya .NET CLI kullanabilirsiniz.
Veri Görüntüleme

Proje çalıştırıldığında, tarayıcıda müşteri bilgileri ve sipariş detayları tablo olarak görüntülenir.
Örnek Çıktı
Müşteri Bilgileri
makefile
Kodu kopyala
Id: 1
Ad: Ayşe Yılmaz
Email: ayse.yilmaz@example.com
Siparişler
Ürün Adı	Birim Fiyat	Miktar	Toplam Tutar
Laptop	7.500,50 ₺	1	7.500,50 ₺
Telefon	3.200,00 ₺	2	6.400,00 ₺
Kulaklık	150,75 ₺	3	452,25 ₺
Genel Toplam: 14.352,75 ₺
