using System;

namespace B10956003_0321
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int result = Add(3, 5);
            //Console.WriteLine(result);
            Car myCar = new Car();
            myCar.ShowInfo();
            //myCar.ChangeColor("blue");
            //myCar.ShowInfo();

            Car CarA = new CarA();
            CarA.OpenDoor();
        }
        static private int Add(int a,int b)
        {
            return a + b;
        }
    }
}
