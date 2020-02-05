using System;

namespace InClass3
{
    class Car
    {
        public string color = "red";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj2.color);
        }
    }
}
