using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var test1 = Kata.GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1");
            var test2 = Kata.GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0");
            var test3 = Kata.GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0");
        }
    }
}
