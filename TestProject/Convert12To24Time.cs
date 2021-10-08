using System;

namespace TestProject
{
    public class Convert12To24Time
    {
        public static string TimeConversion(string s)
        {
            var date = DateTime.Parse(s);
            return date.ToString("HH:mm:ss");
        }
    }
}
