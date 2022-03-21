using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class People<T> : IPersons<T>
    {
        private int size;
        private T[] persons;

        public People()
        {
            size = 0;
            persons = new T[10];
        }

        public int Count { get { return size; } }

        public void Add(T pers)
        {
            persons[size] = pers;
            size++;
        }

        public T Get(int index) { return persons[index]; }
    }

}
