using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Tables
{
    internal class ListClas : IHash
    {
        List<Tuple<string, object>> lst = new List<Tuple<string, object>>();
        public string Add(string key, object value)
        {
            lst.Add(Tuple.Create(key, value));
            return "Went good";
        }

        public object Get(string key)
        {
            object hittat_value = "";
            bool keyFound = false;
            for (int i = 0; i < lst.Count; i++)
            {
                var hittat_key = lst[i].Item1;
                if (hittat_key != null && hittat_key == key)
                {
                    keyFound = true;
                    return $"The value of '{key}' is '{lst[i].Item2}'";
                }
            }
            return "Hittat Inget!";
            
        }
        public object view()
        {
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }
            return null;
        }

        public void Remove(string key)
        {
            bool keyFound = false;
            for (int i = 0; i < lst.Count; i++)
            {
                var hittat_key = lst[i].Item1;
                if (hittat_key != null && hittat_key == key)
                {
                    keyFound = true;
                    lst.RemoveAt(i);
                }
            }
           
        }
    }
}
