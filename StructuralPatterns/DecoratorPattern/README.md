# Decorator Pattern
Decorator tasarım deseninin amacı nesnelere dinamik olarak özellik eklemektir ve nesne kendisi de eklenen özelliklerden habersiz ve ayrı bir konumda olmalıdır. Yani kodun belli kısımlarında nesnelere belli özellikler kazandırmak istiyorsak ve bunu nesnenin kendi classından ayrıştırılmış bir şekilde yapmak istiyorsak decorator tasarım desenini kullanmamız gerekmektedir.

### Component class 
Üzerine dinamik olarak özellik ve davranış eklenecek olan nesnenin classı.

### Decorator class 
Dinamik olarak özelliğin ve davranışın eklendiği class.

### IComponent  
Component ve Decorator classın türediği interface.




![138608327-92ca3520-3e77-4c2f-adff-7be68a0a60f4](https://user-images.githubusercontent.com/90327328/139575735-0d2f12f4-b413-4f19-a769-ef203fe174fc.png)
