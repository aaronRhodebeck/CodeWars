using System;

public class Kata
{
    public static string WhatIsTheTime(string TimeInMirror)
    {
        if (TimeInMirror == "12:00" || TimeInMirror == "06:00")
        {
            return TimeInMirror;
        }
        
        var clockShows = TimeInMirror.Split(':');
        var actualHour = GetHour(int.Parse(clockShows[0]), int.Parse(clockShows[1]));
        var actualMinute = GetMinute(int.Parse(clockShows[1]));
        return String.Format("{0:D2}:{1:D2}", actualHour, actualMinute);
    }

    private static int GetHour(int HourInMirror, int MinuteInMirror)
    {
        if (HourInMirror == 12)
        {
            return 11;
        }

        var actualHour = 11 - HourInMirror;
        if (MinuteInMirror == 0)
        {
            actualHour += 1;
        }
        if (actualHour == 0)
        {
            actualHour = 12;
        }

        return actualHour;
    }

    private static int GetMinute(int MinuteInMirror)
    {
        var actualMinute = 60 - MinuteInMirror;
        if (actualMinute == 60)
        {
            actualMinute = 0;
        }
        return actualMinute;
    }
}