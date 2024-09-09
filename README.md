## E-Ticaret Backend Projesi
Bu proje, bir e-ticaret sistemi için backend uygulamasını içermektedir. Aşağıda proje kapsamında gerçekleştirilen ana özellikler yer almaktadır:

Özellikler
E-Ticaret ve Yönetim Panelleri: Proje, bir e-ticaret mağazası ve yönetici panelini yöneten iki ayrı MVC uygulaması içermektedir.

Veri ve API Katmanları: App.Api.Data katmanı, veritabanı CRUD işlemleri ve JWT kimlik doğrulamasını gerçekleştirmektedir. Tüm veritabanı işlemleri bu API üzerinden yapılmaktadır, böylece web uygulaması ile veri katmanı arasında bir ayrım sağlanmaktadır.

JWT Kimlik Doğrulaması: Projede, güvenli bir kimlik doğrulama mekanizması olarak JWT token'ları kullanılmaktadır. Her rolün (Alıcı, Satıcı, Yönetici) belirli izinleri ve erişim hakları bulunmaktadır.

Dosya Yükleme/İndirme API'si: App.Api.File adında ayrı bir API, dosya yükleme ve indirme işlemlerini gerçekleştirmektedir, özellikle ürün görselleri için kullanılmaktadır.

Rol Tabanlı Yetkilendirme: Sistem, e-ticaret ve yönetim panellerinde rol tabanlı erişim kontrolü uygular, böylece kullanıcılar yalnızca yetkili oldukları işlemleri gerçekleştirebilir.

Entity Framework: Projede veritabanı yönetimi için Entity Framework Core kullanılmıştır. Roller, kategoriler ve ürünler gibi veriler migration ve seed işlemleri ile başlatılmıştır.

Domain Servisleri: İş mantığı, domain servisleri ile kapsüllenmiştir, bu da projeyi modüler hale getirmekte ve SOLID prensiplerine uygunluk sağlamaktadır.

İstemci Taraflı Doğrulama: Hem istemci tarafında hem de sunucu tarafında doğrulamalar kullanılarak veri bütünlüğü sağlanmıştır.

Kullanılan Framework ve Araçlar
ASP.NET Core MVC
ASP.NET Core Web API
Entity Framework Core
JWT Kimlik Doğrulaması
Ardalis.Result ile servis sonuçları
Katmanlar arası veri akışı için DTO (Data Transfer Objects)
Bu proje, veritabanı işlemleri, API çağrıları, kimlik doğrulama ve dosya yönetimini entegre eden kapsamlı bir backend çözümü sunmakta ve modülerlik ile temiz mimariye odaklanmaktadır.
