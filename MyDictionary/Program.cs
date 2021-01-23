using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> MyDicitoanry = new Dictionary<int,string>();
            MyDicitoanry.Add(0, "Kar kuresi");
            MyDicitoanry.Add(1, "Parfüm");
            MyDicitoanry.Add(2, "Oyuncak ayı");

            Console.WriteLine(MyDicitoanry[0]);
            Console.WriteLine(MyDicitoanry[1]);
            Console.WriteLine(MyDicitoanry[2]);

        }
    }
}
