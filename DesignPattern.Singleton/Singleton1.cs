using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    class Singleton1
    {
        // The Singleton's constructor should always be private to prevent
        // direct construction calls with the `new` operator.
        private Singleton1() { }

        // The Singleton's instance is stored in a static field. There are
        // multiple ways to initialize this field, all of them have various pros
        // and cons. In this example we'll show the simplest of these ways,
        // which, however, doesn't work really well in multithreaded program.
        private static Singleton1 _instance;

        // This is the static method that controls the access to the singleton
        // instance. On the first run, it creates a singleton object and places
        // it into the static field. On subsequent runs, it returns the client
        // existing object stored in the static field.
        public static Singleton1 GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton1();
            }
            return _instance;
        }

        // Finally, any singleton should define some business logic, which can
        // be executed on its instance.
        public void someBusinessLogic()
        {
            Console.WriteLine("singleton is doing work...");
        }

        public static void staticWork()
        {
            Console.WriteLine("singleton is executing static method...");
        }

        public string Value { get; set; }
    }
}
