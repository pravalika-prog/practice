using System;
using System.Collections.Generic;
using System.Text;

namespace Traingle
{
   public abstract  class Shape
    {
     public   abstract void draw();
    }
    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("mad");
        }
        public class Circle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("please");
            }
        }
        static void Main()
        {

            Rectangle r = new Rectangle();
            //Circle c = new Circle();
            //c.draw();
        }
    }
}
