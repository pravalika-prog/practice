using System;
using System.Collections.Generic;
using System.Text;

namespace Traingle
{
    interface Multliple
    {
        void show();
    }
    interface common
    {
        void test();
    }
    class promise : Multliple, common
    {
        void Multliple.show()
        {
            Console.WriteLine("system");
        }
        void common.test()
        {
            Console.WriteLine("marry");
        }

        static void Main()
        {
            promise p = new promise();
            Multliple i = p;
            common i1 = p;
            i.show();
            i1.test();

        }

        
    }
}
        
    