using System;
using System.Collections.Generic;
using System.Text;

namespace Number
{
    class method_overloading
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    public class TestMemberOverloading
    {
        public static void Main()
        {
            Console.WriteLine(method_overloading.add(12, 23));
            Console.WriteLine(method_overloading .add(12, 23, 25));
        }
    }
}
