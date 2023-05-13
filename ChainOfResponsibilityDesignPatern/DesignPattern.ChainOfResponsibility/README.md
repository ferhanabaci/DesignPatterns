Chain of Responsibility pattern nedir ?

Bir istegi islemek için bir dizi nesne arasında sorumlulugu dagıtmayı ve böylece istegi işleyecek olan nesneyi dinamik olarak belirlemeyi sağlar.

Istegi gönderen ile  istegi işleyecek nesne arasında bir zincir oluşturur. Her nesne isteği kendi işleyecegi bir şekilde ele alır  ve isteği işleyemezse sonraki nesneye iletir.Bu şekilde istek, zincir boyunca ilerler ve uygun nesne tarafından işlenene kadar devam eder.

Nesneni amacı:
Bir nesneyi işleyecek nesneyi belirlemeyi kolaylaştırmak ve isteği işlemek için nesneler arasında sıkı bagımlılıkları azaltmak.
Zincirdeki her bir nesne, yalnızca kendi sorumluluğundaki işlemleri gerçekleştirir ve diğer nesnelerin bilgisine ihtiyaç duymaz. Bu sayede, yeni nesneler eklemek veya mevcut nesneleri değiştirmek daha esnek hale gelir.

Örneğin, bir web uygulamasında gelen istekleri işleyen bir zincir oluşturulabilir. İstek, ilk olarak doğrulama nesnesine iletilir. Doğrulama nesnesi isteği doğrular ve başarılıysa isteği işleme tamamlanır. Başarısızlık durumunda istek, sonraki nesne olan yetkilendirme nesnesine iletilir. Zincirdeki nesneler sırayla çalışır ve istek, uygun nesne tarafından başarılı bir şekilde işlenene kadar devam eder.

Birçok durumda kullanılabilir, özellikle birden çok nesnenin bir isteği sırayla işlemesi gereken durumlarda faydalıdır. Aynı zamanda, uygulamada sorumlulukların dinamik olarak değişebileceği veya yeni sorumlulukların eklenmesi gerektiği durumlarda da esneklik sağlar.

Bu projede Chain Responsibility kavramı bir banka müşterisinin kredi çekmek için banka çalışanların günlük müştriye kasalarından çıkabilecegi miktara göre bir dizi işleme alma sürecinin anlatılması amaçlanmıştır.
Data olarak MSSQL migration ile adımlar dataya yazılmaktadır. 


![image](https://github.com/ferhanabaci/DesignPatterns/assets/84642053/2b244c70-7eca-4c9a-b804-ae98ccd07c91)

