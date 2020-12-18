using System;
using System.Collections.Generic;
using System.Text;

namespace Ienumerable
{
    class program
    {
        static void Main()
        {
            laptop lp = new laptop();
            lp.Showdetails(laptop.Lenovo, laptop.price1000, laptop.Ram2GB, laptop.i3);
            Console.WriteLine("**************************************");
            lp.Showdetails(laptop.dell, laptop.price1500, laptop.Ram4GB, laptop.i5);
            Console.WriteLine("**************************************");
            lp.Showdetails(laptop.hp, laptop.price2500, laptop.Ram8GB, laptop.i7);
            Console.WriteLine("**************************************");
        }
    }
}

