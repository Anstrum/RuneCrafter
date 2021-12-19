using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RuneCrafter.Project.Misc
{
    static class Debug
    {
        private static bool DebugActive = true;
        private static List<Log> Logs = new List<Log>();

        public static void Print(string DebugText)
        {
            if (DebugActive)
            {
                Console.WriteLine("[DEBUG]\t" + DebugText);
                Logs.Add(new Log(DateTime.Now, DebugText));
            }
        }
        public static void Extract()
        {
            string Path = Environment.CurrentDirectory + "\\Logs";
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            DateTime Date = DateTime.Now;
            string DateString = Date.Day + "-" + Date.Month + "-" + Date.Year + "  " + Date.Hour + "." + Date.Minute + "." + Date.Second;
            Path = Path + "\\Log " + DateString + ".txt";
            string ToWrite = "";
            foreach (Log Message in Logs)
            {
                ToWrite += Message.GetDate().ToString() + "||" + Message.GetContent() + "\n";
                ToWrite += "===================||=========================================================================================||\n";
            }
            File.WriteAllText(Path, ToWrite);
        }
    }
}
