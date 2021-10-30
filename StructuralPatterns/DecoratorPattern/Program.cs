using DecoratorPattern.Example1.Clients;
using DecoratorPattern.Example1.Concrete;
using DecoratorPattern.Example1.Interface;
using DecoratorPattern.Example2.Business.Concrete;
using DecoratorPattern.Example2.Model.Concrete;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example_1

            IPizza pizza = new Pizza();

            Client.Presentation("Malzemesiz Hali => ", pizza );
            Client.Presentation("Peynir ile decore edildi =>", new CheeseDecorator(pizza));
            Client.Presentation("Domates ile decore edildi =>", new TomatoDecorator(pizza));
            Client.Presentation("Zeytin ile dekore edildi =>", new OliveDecorator(pizza));
            Client.Presentation("Peynir ve zeytin ile decore edildi =>",new CheeseDecorator(new OliveDecorator(pizza)));
            Client.Presentation("Domates ve peynir ile decore edildi =>", new TomatoDecorator(new CheeseDecorator(pizza)));

            #endregion

            #region Example_2

            var EngineeringStudent = new ChoiceDiscount()
            {
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                Department = "Engineering ",
                RegistrationFee = 25000

            };

            StudentRegistration studentRegistration = new StudentRegistration(EngineeringStudent);
            studentRegistration.DiscountedPercantege = 25;

            Console.WriteLine($"Not appliend discount : {EngineeringStudent.RegistrationFee}");
            Console.WriteLine($"Applied discount :{studentRegistration.RegistrationFee}");



            var NurseStudent = new WarVeteranDiscount()
            {
                FirstName = "Elif",
                LastName = "Yıldırım",
                Department = "Nurse",
                RegistrationFee = 11000

            };

            StudentRegistration studentRegistration1 = new StudentRegistration(NurseStudent);
            studentRegistration1.DiscountedPercantege = 40;

            Console.WriteLine($"Not appliend discount : {NurseStudent.RegistrationFee}");
            Console.WriteLine($"Applied discount :{studentRegistration1.RegistrationFee}");


            #endregion
            Console.ReadKey();
        }
    }
}
