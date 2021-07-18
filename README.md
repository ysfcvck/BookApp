# BookApp
Bu proje resmi olmayan online kitap satış uygulamasıdır.
.NET Core 3.1 versiyonu ile yazılmıştır.

Proje dosyasında Connection Stringlerin değiştirileceği yollar:
-appsettings.json
-Models > Context > Context


SQL Server Connection String:

"Server=ServerAdı; Database=DatabaseAdı; Trusted_Connection=True;"

Örnek: "Server=DESKTOP-68O6AVP\\SQLEXPRESS; Database=Örn:BookAppDb; Trusted_Connection=True;"

*Server adınız DESKTOP-68O6AVP\SQLEXPRESS şeklinde ise tek Backslash(\) olduğundan dolayı hata verebilir. Eğer hata verirse yukarıdaki
örnekte olduğu gibi iki adet Backslash(\\) kullanın.


Açıklama:
Uygulamada yönetici ve kullanıcı olmak üzere iki arayüz kullanıldı. Kullanıcıların göreceği arayüzde giriş, kayıt, reklam, kitap, kitap detayı, kategori, alt kategori, sepet, ödeme ve iletişim sayfaları bulunuyor.
Yönetici arayüzünde reklam, kitap, kategori, sipariş ve kayıtlı üye işlemlerinin yapılacağı sayfalar bulunuyor.

Identity altyapısı ile rol tabanlı yetkilendirme kullanıldı. Kullanıcılara atanan roller sayesinde, belirlenen kriterlere göre kullanıcıların yetkisi olmadığı sayfalara erişimi engellendi.
