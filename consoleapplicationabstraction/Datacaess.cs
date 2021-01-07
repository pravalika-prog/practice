using System;
using System.Collections.Generic;
using System.Text;

namespace shoppin4ab
{
 public abstract  class Datacaess
    {
        public virtual  string Loadconnectionstring(string name)
        {
            Console.WriteLine("connection from mysqlilte ");
            return "testconnectionstring";
        }
        public abstract void Loaddataa(string sql);
        public abstract void  savedata(string sql);
    }
}
