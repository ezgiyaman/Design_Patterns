# Singleton Pattern

Singleton design pattern,bir nesnenin kullanım süresi boyunca bir kez üretilmesini ve tek bir instance’ının olmasın kontrol altında tutmaktadır. Aynı zamanda bu nesne sınıf dışından da erişilebilinirdir.Bir sınıfın bir anda sadece bir örneğinin olması istenildiği zamanlarda kullanılır.

Bu desenin kullanımı oldukça basittir. Singleton deseni uygulanacak sınıfın constructor metodu private olarak tanımlanır ve sınıfın içinde kendi türünden static bir sınıf tanımlanır. Tanımlanan bu sınıfa erişimi sağlayacak bir metot veya property de sınıfa eklenir.Bu desenin kullanım şekli genel olarak böyledir.


![138560468-73a69017-261d-4e03-9cb8-941b710e951e](https://user-images.githubusercontent.com/90327328/139574805-6cd87994-cdc6-4288-b5b0-d1d8d555bdf7.png)
