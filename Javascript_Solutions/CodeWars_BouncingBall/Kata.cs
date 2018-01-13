public class BouncingBall
{
    public static int bouncingBall(double h, double bounce, double window)
    {
        if (bounce > 1 || bounce < 0 || h < window) return -1;
        var timesSeen = 0;
        for (int i = 1; h > window; i++)
        {
            h *= bounce;
            timesSeen = 2 * i;
        }
        return timesSeen - 1;
    }
}