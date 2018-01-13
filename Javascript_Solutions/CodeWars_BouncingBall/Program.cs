using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool test1 = BouncingBall.bouncingBall(3.0, 0.66, 1.5) == 3;
            bool test2 = BouncingBall.bouncingBall(30.0, 0.66, 1.5) == 15;
        }
    }
}
