
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            bool first = (TimeFormat.GetReadableTime(0) == "00:00:00");
            bool second = (TimeFormat.GetReadableTime(5) == "00:00:05");
            bool third = (TimeFormat.GetReadableTime(60) == "00:01:00");
            bool fourth = (TimeFormat.GetReadableTime(86399) == "23:59:59");
            bool fifth = (TimeFormat.GetReadableTime(359999) == "99:59:59");
        
        }
    }
}
