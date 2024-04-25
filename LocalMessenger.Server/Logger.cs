using System;
using System.IO;

namespace LocalMessenger.Server
{
    public class Logger
    {
        private string logFilePath;

        public Logger(string filePath)
        {
            logFilePath = filePath;
        }

        public void Log(string message)
        {
            try
            {
                if (!File.Exists(logFilePath))
                {
                    using (StreamWriter sw = File.CreateText(logFilePath))
                    {
                        sw.WriteLine($"[{DateTime.Now}] {message}");
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(logFilePath))
                    {
                        sw.WriteLine($"[{DateTime.Now}] {message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{DateTime.Now}] Error occurred while logging: {ex.Message}");
            }
        }
    }
}
