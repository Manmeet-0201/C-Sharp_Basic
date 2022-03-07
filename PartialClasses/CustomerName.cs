using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class CustomerName
    {
        public string getFullName(string firstname, string lastname)
        {
            return firstname + " " + lastname;
        }
    }
}
