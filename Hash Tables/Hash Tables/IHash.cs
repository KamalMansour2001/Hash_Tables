using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Tables
{
    internal interface IHash
    {
        public string Add(string key, object value);
        public object Get(string key);
        public void Remove(string key);


    }
}
