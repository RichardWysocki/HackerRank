using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Repository
{
    class LoggerFile : IRepository<Log>
    {
        private readonly List<Log> _list = new List<Log>();

        public LoggerFile()
        {
            for (int i = 0; i < 5; i++)
            {
                _list.Add(new Log { Source = $"LoggerFile Source {i+1}", Error = $"LoggerFile Error {i + 1}" });
            }
        }

        public void Add(Log record)
        {
            _list.Add(record);
        }

        public List<Log> GetAll()
        {
            return _list;
        }
    }
}
