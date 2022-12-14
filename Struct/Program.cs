using System;

namespace Struct
{
    class Program
    {
         struct Person
        {
            public string name;
            public int age;

        }

        static void Main(string[] args)
        {
            Person point = new Person();
            point.age = 27;
            point.name = "Davit";

                Console.WriteLine(point.name +"  "+ point.age );
        }
       


    }
}
