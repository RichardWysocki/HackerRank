using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Repository
{
    public class LoggerDB:  IRepository<Log>
    {
        private readonly List<Log> _list = new List<Log>();

        public LoggerDB()
        { 
            for (int i = 0; i < 10; i++)
            {
                _list.Add(new Log { Source = $"LoggerDB Source {i + 1}", Error = $"LoggerDB Error {i + 1}" });
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
