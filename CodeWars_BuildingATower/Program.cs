using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", Kata.TowerBuilder(1)));
            Console.WriteLine(Kata.TowerBuilder(3));
            Console.WriteLine(Kata.TowerBuilder(10));
            Console.WriteLine(Kata.TowerBuilder(2));
            Console.WriteLine(Kata.TowerBuilder(30));
        }
    }
}
