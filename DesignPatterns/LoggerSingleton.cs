using System.IO;

namespace DesignPatterns
{
    public sealed class Singleton: ILogBase
    {
        private static Singleton _instance = null;
        private static readonly object Padlock = new object();
        private readonly StreamWriter _mLogFile;

        Singleton()
        {
            var mFileName = "SingletonFile.txt";
            _mLogFile = new StreamWriter(mFileName, true) { AutoFlush = true };
        }

        public static Singleton Instance
        {
            get
            {
                lock (Padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            _mLogFile.WriteLine(message);
        }
    }

    public class LoggerSingleton : ILogBase
    {
        private readonly string _mFileName;
        private StreamWriter _mLogFile;


        public LoggerSingleton(string fileName)
        {
            _mFileName = fileName;

        }


        public void Log(string message)
        {
            _mLogFile.WriteLine(message);
        }
    }
}
