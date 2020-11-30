using System;
using System.Collections.Generic;
using System.Text;

namespace Number
{
    class method_overriding
    {
        public virtual  void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
      class Dog : method_overriding
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread...");
        }
    }
    public class TestOverriding
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.eat();
        }
    }
}
