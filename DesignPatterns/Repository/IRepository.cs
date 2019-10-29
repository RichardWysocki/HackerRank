using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface IRepository<T>
    {

        void Add(T record);

        List<T> GetAll();



    }
}
