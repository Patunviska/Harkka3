using System;
using Humanizer;

namespace AppLogger
{
    public class Logger
    {
        public static void Log(string text)
        {
            Console.WriteLine(text);
        }

        public static void LogHumanized(string text)
        {
            
            string humanizedText = text.Humanize();
            Console.WriteLine(humanizedText);

        }
    }
}

