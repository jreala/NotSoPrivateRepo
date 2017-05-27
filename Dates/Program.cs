﻿using System;

namespace TimeDateManipulation
{
    class Program
    {
        private const string UtcMinus2 = "UTC-02";

        static void Main(string[] args)
        {
            var now = DateTime.Now;
            var dateLong = now.ToString("yyyy-MM-dd hh:mm:ss");
            var thirtyOneDaysFromNow = now.AddDays(31).ToString("MM/dd/yyyy hh:mm:ss");
            var daySuffix = GetSuffix(now.Day);
            var twoYearsThirtyOneDaysFromNow = now.AddYears(2).AddDays(31).ToString($"dddd MMMM d{daySuffix} yyyy");
            
            var timeZoneinfo = TimeZoneInfo.FindSystemTimeZoneById(UtcMinus2);
            var utcMinusTwo = TimeZoneInfo.ConvertTime(now, timeZoneinfo);
            
            Console.WriteLine($"Current Date: {dateLong}");
            Console.WriteLine($"Thirty One Days From Now: {thirtyOneDaysFromNow}");
            Console.WriteLine($"Two Years and Thirty One Days From Now: {twoYearsThirtyOneDaysFromNow}");
            Console.WriteLine($"Time in UTC-2: {utcMinusTwo} {timeZoneinfo.StandardName}");
            Console.ReadLine();
        }

        private static string GetSuffix(int day)
        {
            string suffix;
            switch (day)
            {
                case 1:
                    suffix = "\\s\\t";
                    break;
                case 21:
                    suffix = "\\s\\t";
                    break;
                case 31:
                    suffix = "\\s\\t";
                    break;
                case 2:
                    suffix = "\\n\\d";
                    break;
                case 22:
                    suffix = "\\n\\d";
                    break;
                case 3:
                    suffix = "\\r\\d";
                    break;
                case 23:
                    suffix = "\\r\\d";
                    break;
                default:
                    suffix = "\\t\\h";
                    break;
            }
            return suffix;
        }
    }
}
