public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        string hours = (seconds / 3600).ToString();
        string mins = ((seconds % 3600) / 60).ToString();
        string sec = ((seconds % 3600) % 60).ToString();
        return $"{hours.PadLeft(2, '0')}:{mins.PadLeft(2, '0')}:{sec.PadLeft(2, '0')}";

    }
}

//
public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
    }
}
//
using System;

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        var t = TimeSpan.FromSeconds(seconds);
        return string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
    }
}
