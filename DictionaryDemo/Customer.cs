using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Customer
    {
        string Name;
        int ID;
        public Customer(string Name,int ID)
        {
            this.Name = Name;
            this.ID = ID;
        }
        public override string ToString()
        {
            return Name + "-" + ID;
        }
    }
}
