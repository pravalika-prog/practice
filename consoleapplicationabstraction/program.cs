using System;
using System.Collections.Generic;

namespace shoppin4ab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Datacaess> databases = new List<Datacaess>()
                {
                  new Sqldatacess(),
                  new sqllitedatacess()
                };
            foreach (var db in databases)
            {
                //db.Loadconnectionstring("demo");
                //db.Loaddataa("save from table");
                //db.savedata("insert into table");
                //Console.WriteLine();
                Console.WriteLine( db.Loadconnectionstring("demo"));
                db.Loaddataa("myname");
                db.savedata("my priya");
            }
            Console.ReadLine();

        }
    }
}
