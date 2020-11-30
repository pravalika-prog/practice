using System;

namespace Number
{
    class Program
    {
        public enum days
        {
            monday = 1, tuesday = 2, wednesday = 14, thursday = 17, friday = 18, saturady = 19, sunday = 20
        }
        public static days meetingdate { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine(meetingdate = days.thursday);
            foreach(int i in Enum.GetValues(typeof(days)))
            //days d = 0;
            //days d = (days)1;
            //days d = days.sunday;
            Console.WriteLine( i+":"+(days)i);
            foreach (String s in Enum.GetNames(typeof(days)))
                Console.WriteLine(s);
            //Console.WriteLine("Hello World!");
        }
    }
}
