using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.Example2
{
    public class Singleton
    {
        private static Singleton _singleton;
        private Singleton() { } //Constructorı private yapılarak bu sınıfı dışarıdan erişime kapatıp,örneklem alınmasını engelledik.
        
        public static Singleton CreateSingletonObject()
        {
            if(_singleton == null) //Eğer singleton içerisi boş ise şart tutar.
            {
                _singleton = new Singleton(); //nesne üretilir.
            }
            
            return _singleton; //_singleton nesnesi dolu ise bize onu verecektir.
        }
    }
}
