using System;

namespace DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton1 testNew = new Singleton1(); //compile error because the constructor is private.
            Singleton1 s1 = Singleton1.GetInstance();
            Singleton1 s2 = Singleton1.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
            s1.someBusinessLogic();
            Singleton1.staticWork();

            Console.ReadKey();
        }
    }
}
