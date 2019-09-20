using System.IO;

namespace DesignPatterns
{
    public sealed class Singleton: ILogBase
    {
        private static Singleton _instance = null;
        private static readonly object Padlock = new object();
        private readonly string _mFileName;
        private StreamWriter _mLogFile;

        Singleton()
        {
            _mFileName = "SingletonFile.txt";
            Init();
        }
        private void Init()
        {
            _mLogFile = new StreamWriter(_mFileName, true);
            _mLogFile.AutoFlush = true;
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

    //public class LoggerSingleton : ILogBase
    //{
    //    private readonly string _mFileName;
    //    private StreamWriter _mLogFile;


    //    public LoggerSingleton(string fileName)
    //    {
    //        _mFileName = fileName;
    //        Init();
    //    }
    //    private void Init()
    //    {
    //        _mLogFile = new StreamWriter(_mFileName, true);
    //        _mLogFile.AutoFlush = true;
    //    }
    //    public void Terminate()
    //    {
    //        _mLogFile.Close();
    //    }

    //    public void Log(string message)
    //    {
    //        _mLogFile.WriteLine(message);
    //    }
    //}
}
