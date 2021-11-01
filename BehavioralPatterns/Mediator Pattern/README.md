# Mediator Pattern
Mediator design patternini birbirleriyle ilişkili eş görevli bir grup nesneyi tek merkezden yönetmek ve aralarında gevşek bağlı (loosely coupled) sistemler kurmak istediğimiz durumlarda kullandığımız tasarım desenidir.Birçok nesne birbiri ile iletişime geçmek yerine bu tasarım deseni sayesinde birbirlerine bağlanırlar. Bu tasarım deseni sayesinde karmaşıklık azalır ve sistemin anlaşırlığı kolaylaşır.

* ### Mediator : Bir arayüzdür ve iş arkadaşları arasındaki olası tüm etkileşimleri tanımlamaktadır.

* ### ConcreteMediator: Mediator arabirimini uygulayan ve meslektaş nesneler arasındaki iletişimi koordine eden bir sınıftır.

* ### Colleague: Soyut bir sınıftır ve bu soyut sınıf, Concrete Colleague sınıfları tarafından uygulanacaktır.

* ### ConcreteColleage1 / ConcreteColleage2: Bunlar sınıftır ve Colleague arabirimini uygularlar.Eğer iki sınıf birbiri ile iletişim kurmak isterse doğrudan iletişim kurmayacak bunun yerine ConcreteMediator aracılığıyla iletişim kuracaktır.




![word-image-51](https://user-images.githubusercontent.com/90327328/139720937-aeb44742-7d7e-4e42-865c-b997b18936bf.png)
