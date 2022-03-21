using System;
using System.Collections.Generic;
using System.Text;

namespace B10956003_0321
{
    class Car
    {   
        //封裝
        string color = "red";
        int cc = 15000;
        string brand = "BMW";
        //到此
        public void StartEngin()
        {
            Console.WriteLine("發動引擎");
        }

        public void ShowInfo()
        {
            Console.WriteLine("顏色:" + color);
            Console.WriteLine("cc數:" + cc);
            Console.WriteLine("品牌:" + brand);
        }
        public void ChangeColor(string color)
        {
            this.color = color;
        }
        public void OpenDoor()
        {
            Console.WriteLine("側開");
        }
    }
}
