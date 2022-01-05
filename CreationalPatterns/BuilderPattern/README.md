# Builder Pattern 

Birden fazla parçadan oluşan nesnelerin üretilmesinden sorumludur. Tek ara yüz kullanarak karmaşık bir nesne grubundan gerektiğince parça yaratılmasını sağlar. Nesne grubu kullanıldıkça istenilen şekilde yapılanır ve bu sayede kullanılmayan parçaların gereksiz yere yaratılma durumu ortadan kaldırılmış olur.

### Builder
Product nesnesinin oluşturulması için gerekli arayüzü sağlar.

### ConcreteBuilder
Product nesnesini oluşturur. Product ile ilişkili temel özellikleri ve donanımı sağlayan sınıftır.

### Director
Builder arayüzünü kullanarak nesne örneklemesini yapar.

### Product
Üretim sonucu ortaya çıkan nesneyi temsil eder.Temel özellikleri ConcreteBuilder tarafından inşa edilir.
