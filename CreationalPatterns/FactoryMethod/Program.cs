using FactoryMethod.Example1.FactoryCreator;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example1
            for (int i = 0; i <= 3; i++)
            {
                var type = Factory.Get(i);
                if (type != null)
                {
                    Console.WriteLine("This is Product : " + type.Variationlity());
                }

                #endregion
                Console.ReadKey();
            }
        }

    }
}
