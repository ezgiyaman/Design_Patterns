using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.Example1
{
    public class SingletonWithProperty
    {
        private static SingletonWithProperty _singletonObject; //Field
        private SingletonWithProperty() // constructor oluşturup , dış erişime kapatıldı.
        {

        }
        public static SingletonWithProperty SingletonObject
        {
            get
            {
                if (_singletonObject == null)
                {
                    _singletonObject = new SingletonWithProperty();
                }
                return _singletonObject; //Null değilse yaratılan değişken geri döndürülüyor.
            }
        }
        public int Çıkarma(int s1, int s2) => s1 - s2;
    }
}

