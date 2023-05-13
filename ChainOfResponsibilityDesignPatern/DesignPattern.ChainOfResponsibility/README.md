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


What is the Chain of Responsibility pattern?

It allows to distribute responsibility among a number of objects to process a request and thus dynamically determine the object that will process the request.

It creates a chain between the sender of the request and the object that will process the request. Each object handles the request in its own way, and if it fails to process the request, it forwards it to the next object. In this way, the request continues down the chain and continues until it is processed by the appropriate object.

Object purpose: To make it easier to identify the object to handle an object and to reduce tight dependencies between objects to handle the request. Each object in the chain only performs its own operations and does not need the knowledge of other objects. This makes it more flexible to add new objects or modify existing ones.

For example, a web application could create a chain that processes incoming requests. The request is first passed to the validation object. The validation object validates the request, and if successful, processing the request is complete. In case of failure, the request is forwarded to the next object, the authorization object. Objects in the chain run sequentially and the request continues until it is successfully handled by the appropriate object.

It can be used in many situations, especially useful when multiple objects need to process a request sequentially. It also provides flexibility in implementation where responsibilities may change dynamically or new responsibilities need to be added.

In this project, the concept of Chain Responsibility is aimed to explain a series of processing processes according to the amount that bank employees can get out of their daily customer safes in order to take a loan from a bank customer. Steps are written to the data with MSSQL migration as data.


