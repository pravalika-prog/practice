using System;
using System.Collections.Generic;
using System.Text;

namespace Ienumerable
{


    class laptop : laptop1
    {
        public void Showdetails(string Name, string Price, string Processor, string ram)
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Processor:" + Processor);
            Console.WriteLine("ram:" + ram);
        }
    }
}

    
       
 //   class program : baselaptop
 //   {
 //       public void Showdetails(string name, string price, string ram, string processor);
 //       {
 //           Console.WriteLine("Name : "+name);
 //           Console.WriteLine("Price : " + price);
 //           Console.WriteLine("Processor:"+processor);
 //Console.WriteLine("ram:"+ram);
 //       }
 //   }
   


