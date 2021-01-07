using System;
using System.Collections.Generic;
using System.Text;

namespace shoppin4ab
{
    public class sqllitedatacess : Datacaess
    {
        public override string Loadconnectionstring(string name)
        {
            string output=    base.Loadconnectionstring(name);
            output += ("sqllite");
            return output;
        }


        public override void Loaddataa(string sql)
        {
            Console.WriteLine("connecting");
        }
        public  override void savedata(string sql)
        {
            Console.WriteLine("recovering");
        }
    }
}
    
