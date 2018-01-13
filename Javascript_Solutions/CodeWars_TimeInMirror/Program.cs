using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var test1 = Kata.WhatIsTheTime("06:35"); // "05:25";
            var test2 = Kata.WhatIsTheTime("11:59"); // "12:01";
            var test3 = Kata.WhatIsTheTime("12:02"); // "11:58";
            var test4 = Kata.WhatIsTheTime("12:00"); // "12:00";
            var test5 = Kata.WhatIsTheTime("02:00"); // "10:00";
        }
    }
}
