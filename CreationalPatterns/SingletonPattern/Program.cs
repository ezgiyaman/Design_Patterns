using SingletonPattern.Example1;
using SingletonPattern.Example2;
using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example1
            Console.WriteLine($"Sonuç: {SingletonWithProperty.SingletonObject.Çıkarma(12,5)}");

            #endregion
          

            #region Example2

            //Singleton singleton = new Singleton(); //Burada kullanılmaz.Çünkü Singleton ile üretilen nesneleri uygulamanın herhangi bir yerinde çağırabiliriz.Ancak üretmemiz mümkün değildir.

            var singleton = Singleton.CreateSingletonObject(); //Bu method sayesinde Singleton.cs bir nesne sınıf içinde üretilip bize burda geri dönecek.
            #endregion

            Console.ReadKey();
        }
    }
}
