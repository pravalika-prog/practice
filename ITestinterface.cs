using System;
using System.Collections.Generic;
using System.Text;

namespace Traingle
{
    interface ITestinterface
    {
        void add(int a, int b);
    }
    interface ITestinterface2: ITestinterface
    {

        void sub(int a, int b);
    }
    class implementation : ITestinterface2
    {

        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            implementation obj = new implementation();
            ITestinterface2 i = obj;
            i.add(10, 20);
            i.sub(30, 40);
           // obj.add(10, 20);
           // obj.sub(20, 30);
        }
    }
}



