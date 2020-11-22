using System;
using System.Threading;

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

            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );
            Thread t1 = new Thread(() => {
                Singleton1 s3 = Singleton1.GetInstance();
                s3.Value = "abc";
                Console.WriteLine($"s3 value is {s3.Value}");
            });
            Thread t2 = new Thread(() => {
                Singleton1 s4 = Singleton1.GetInstance();
                s4.Value = "xyz";
                Console.WriteLine($"s4 value is {s4.Value}");
            });
            //if (s3 == s4)
            //{
            //    Console.WriteLine("Singleton works, both variables contain the same instance.");
            //}
            //else
            //{
            //    Console.WriteLine("Singleton failed, variables contain different instances.");
            //}
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.ReadKey();
        }
    }
}
