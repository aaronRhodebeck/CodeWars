using System;

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int finalSeconds = seconds % 60;
        seconds /= 60;
        int minutes = seconds % 60;
        int hours = seconds / 60;

        return String.Format("{0}:{1}:{2}",
                                hours.ToString("D2"), 
                                minutes.ToString("D2"), 
                                finalSeconds.ToString("D2"));
    }
}