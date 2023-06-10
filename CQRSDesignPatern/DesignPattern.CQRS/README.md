## CQRS design pattern nedir ?

CQRS (Command Query Responsibility Segregation) tasarım deseni, yazılım mimarisinde kullanılan bir desendir. 
Bu desen, bir uygulamanın veri okuma (query) ve veri yazma (command) işlemlerini birbirinden ayırarak, daha esnek ve ölçeklenebilir bir yapı oluşturmayı amaçlar. 
CQRS, uygulamanın performansını ve bakımını iyileştirmeye yardımcı olur.
CQRS, aşağıdaki temel prensiplere dayanır:
1. Komutlar (Commands): Uygulamanın durumunu değiştiren işlemlerdir. Örneğin, bir veri tabanına veri eklemek, güncellemek veya silmek gibi işlemler komutlar kategorisine girer. Komutlar genellikle iş mantığı ve doğrulama işlemlerini içerir.
2. Sorgular (Queries): Uygulamanın durumunu okuyan işlemlerdir. Veri tabanından veri almak veya filtrelemek gibi işlemler sorgular kategorisine girer. Sorgular, veri okuma işlemlerini gerçekleştirir ve genellikle iş mantığı içermez.
CQRS tasarım deseni, komut ve sorgu işlemlerini farklı modeller ve hizmetler olarak ayırarak, her birinin bağımsız olarak geliştirilmesine, test edilmesine ve ölçeklenmesine olanak tanır. Bu sayede, uygulamanın karmaşıklığı azalır ve performans iyileştirmeleri daha kolay hale gelir



