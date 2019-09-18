using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns
{
    //public class LoggerSingle : ILogBase
    //{
    //    public void Log(string message)
    //    {
    //        throw new NotImplementedException();
    //    }




    //}

    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }

    class LoggerSingleton : ILogBase
    {
        private string mFileName;
        private StreamWriter mLogFile;
        public string FileName
        {
            get
            {
                return mFileName;
            }
        }
        public LoggerSingleton(string fileName)
        {
            mFileName = fileName;
        }
        public void Init()
        {
            mLogFile = new StreamWriter(mFileName, true);
        }
        public void Terminate()
        {
            mLogFile.Close();
        }
        public void ProcessLogMessage(string logMessage)
        {
            // FileLogger implements the ProcessLogMessage method by
            // writing the incoming message to a file.
            mLogFile.WriteLine(logMessage);
        }

        public void Log(string message)
        {
            mLogFile.WriteLine(message);
            mLogFile.Flush();
        }
    }
}
