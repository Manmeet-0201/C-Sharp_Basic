using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface IPersons<T> : ICounter<T>
    {
        void Add(T item);
    }
}
