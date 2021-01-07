using System;
using System.Collections.Generic;
using System.Text;

namespace shoppin4ab
{
  public  class Sqldatacess : Datacaess
    {
       
         public override void Loaddataa(string sql)
        {
            Console.WriteLine("connecting");
        }
    public  override void  savedata(string sql)
        {
            Console.WriteLine("recovering");
        }
                
    }
}
