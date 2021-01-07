using System;
using System.Collections.Generic;
using System.Text;

namespace shoppin4ab
{
 public   interface Idatacess
    {
         string Loadconnectionstring(string name);
         void Loaddataa(string sql);
        void savedata(string sql);
    }
}
