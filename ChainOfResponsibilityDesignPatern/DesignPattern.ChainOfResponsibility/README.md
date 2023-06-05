## Chain of Responsibility pattern nedir ?

Bir istegi islemek için bir dizi nesne arasında sorumlulugu dagıtmayı ve böylece istegi işleyecek olan nesneyi dinamik olarak belirlemeyi sağlar.

Istegi gönderen ile  istegi işleyecek nesne arasında bir zincir oluşturur. Her nesne isteği kendi işleyecegi bir şekilde ele alır  ve isteği işleyemezse sonraki nesneye iletir.Bu şekilde istek, zincir boyunca ilerler ve uygun nesne tarafından işlenene kadar devam eder.

Nesneni amacı:
Bir nesneyi işleyecek nesneyi belirlemeyi kolaylaştırmak ve isteği işlemek için nesneler arasında sıkı bagımlılıkları azaltmak.
Zincirdeki her bir nesne, yalnızca kendi sorumluluğundaki işlemleri gerçekleştirir ve diğer nesnelerin bilgisine ihtiyaç duymaz. Bu sayede, yeni nesneler eklemek veya mevcut nesneleri değiştirmek daha esnek hale gelir.

Birçok durumda  Chain of Responsibility pattern kullanılabilir, özellikle birden çok nesnenin bir isteği sırayla işlemesi gereken durumlarda faydalıdır. Aynı zamanda, uygulamada sorumlulukların dinamik olarak değişebileceği veya yeni sorumlulukların eklenmesi gerektiği durumlarda da esneklik sağlar.

## Projede kullanılan örnek senaryo

Bu projede Chain Responsibility kavramı bir banka müşterisinin ihtiyac kredisi çekmek amacıyla bankaya gelmektedir. Banka da birden fazla çalışan vardır ve bu çalışanların gün içersinde kasasından çıkrabileceği bir fiyat limidi vardır.Müşteri ilk veznadara gelerek 150 tl para çekmek istediğini belirtir. Veznadar kasasından gün içersinde sadece 50 Tl çıkarabilecegini belirterek onu şube müdür yardımcısına yönledirir bu şekilde kasasından müşteriye istediği tutarı çıkarana, olumlu veya olumsuz yanıt alana kadar bu işlem bir dizi halinde devan bir banka yönlendirme uygulaması yapılmıştır.

## Kullanılan teknolojiler
.Net core 5.0
MSSQL



## What is the Chain of Responsibility pattern ?

It allows to distribute responsibility among a number of objects to process a request and thus dynamically determine the object that will process the request.

It creates a chain between the sender of the request and the object that will process the request. Each object handles the request in its own way, and if it fails to process the request, it forwards it to the next object. In this way, the request continues down the chain and continues until it is processed by the appropriate object.

Object purpose:
To make it easier to identify the object to handle an object and to reduce tight dependencies between objects to handle the request.
Each object in the chain only performs its own operations and does not need the knowledge of other objects. This makes it more flexible to add new objects or modify existing ones.

The Chain of Responsibility pattern can be used in many situations, especially useful when multiple objects need to process a request sequentially. It also provides flexibility in implementation where responsibilities may change dynamically or new responsibilities need to be added.

## Sample scenario used in the project

In this project, the concept of Chain Responsibility comes to the bank to attract a consumer loan from a bank customer. There is more than one employee in the bank and there is a price limit that these employees can take out of their safe during the day. The customer comes to the first teller and states that he wants to withdraw 150 TL. Saying that he can only take out 50 TL from the cashier's safe during the day, he directs him to the assistant branch manager. In this way, until the customer gets the amount they want from the cashier's safe and receives a positive or negative response, this process is followed by a series of bank referrals.

## Used technologies
.Net core 5.0
MSSQL
