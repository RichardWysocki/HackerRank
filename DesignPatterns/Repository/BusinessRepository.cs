﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Repository
{
    class BusinessRepository
    {
        private readonly IRepository<Log> _repositoryFile;
        private readonly IRepository<Log> _repositoryDb;

        public BusinessRepository(IRepository<Log> repositoryFile, IRepository<Log> repositoryDB)
        {
            _repositoryFile = repositoryFile;
            _repositoryDb = repositoryDB;
        }

        public List<Log> getAllLogs()
        { 
            var data = new List<Log>();
            data.AddRange(_repositoryFile.GetAll());
            data.AddRange(_repositoryDb.GetAll());
            return data;
        }

        public void  AddFileLog(Log recordLog)
        {
            _repositoryFile.Add(recordLog);
        }

        public void AddDBLog(Log recordLog)
        {
            _repositoryDb.Add(recordLog);
        }

    }
}
