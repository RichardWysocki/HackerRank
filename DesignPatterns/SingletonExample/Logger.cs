﻿using System.IO;

namespace DesignPatterns.SingletonExample
{


    public class Logger : ILogBase
    {
        private readonly string _logFile;

        public Logger(string logFile)
        {
            _logFile = logFile;
        }

        public void Log(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(_logFile, true))
            {
                streamWriter.AutoFlush = true;
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}
