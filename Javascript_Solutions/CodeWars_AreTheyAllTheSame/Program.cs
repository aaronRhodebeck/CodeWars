using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] {11, 144, 19, 161, 19, 144, 19, 11};
            int[] b = new int[] {11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19};
            bool r = AreTheySame.comp(a, b);
        }
    }
}
