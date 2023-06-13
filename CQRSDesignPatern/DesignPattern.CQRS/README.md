## CQRS design pattern nedir ?

CQRS (Command Query Responsibility Segregation) tasarım deseni, yazılım mimarisinde kullanılan bir desendir. 
Bu desen, bir uygulamanın veri okuma (query) ve veri yazma (command) işlemlerini birbirinden ayırarak, daha esnek ve ölçeklenebilir bir yapı oluşturmayı amaçlar. 
CQRS, uygulamanın performansını ve bakımını iyileştirmeye yardımcı olur.
CQRS, aşağıdaki temel prensiplere dayanır:
1. Komutlar (Commands): Uygulamanın durumunu değiştiren işlemlerdir. Örneğin, bir veri tabanına veri eklemek, güncellemek veya silmek gibi işlemler komutlar kategorisine girer. Komutlar genellikle iş mantığı ve doğrulama işlemlerini içerir.
2. Sorgular (Queries): Uygulamanın durumunu okuyan işlemlerdir. Veri tabanından veri almak veya filtrelemek gibi işlemler sorgular kategorisine girer. Sorgular, veri okuma işlemlerini gerçekleştirir ve genellikle iş mantığı içermez.
CQRS tasarım deseni, komut ve sorgu işlemlerini farklı modeller ve hizmetler olarak ayırarak, her birinin bağımsız olarak geliştirilmesine, test edilmesine ve ölçeklenmesine olanak tanır. Bu sayede, uygulamanın karmaşıklığı azalır ve performans iyileştirmeleri daha kolay hale gelir


Bu projede bir temel bir ürün ekleme çıkarma ve update işlemlerinin yapıldığı bir uygulama yapılmak amaçlanmıştır. Ürün detaylarını getirebilir ürünün güncelleyebilir yada silebilirsiniz. Bu işlemler CQRS pattern göre çalışmaktadır. 


## What is CQRS design pattern ?

The CQRS (Command Query Responsibility Segregation) design pattern is a pattern used in software architecture.
This pattern aims to create a more flexible and scalable structure by separating the data reading (query) and data writing (command) operations of an application.
CQRS helps to improve the performance and maintenance of the application.
CQRS is based on the following basic principles:
1. Commands: Operations that change the state of the application. For example, operations such as adding, updating or deleting data in a database fall under the category of commands. Commands often contain business logic and validation operations.
2. Queries: These are the operations that read the status of the application. Operations such as retrieving or filtering data from the database fall under the category of queries. Queries handle data read operations and generally do not contain business logic.
The CQRS design pattern separates command and query operations into different models and services, allowing each to be developed, tested, and scaled independently. This reduces the complexity of the application and makes performance improvements easier.


In this project, it is aimed to make an application in which a basic product, add, remove and update operations are made. You can bring the product details, update or delete the product. These operations work according to the CQRS pattern.
