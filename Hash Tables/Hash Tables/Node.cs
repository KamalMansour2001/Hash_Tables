using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Tables
{
    internal class Node
    {
        //Data
        public student Data { get; set; }

        //Link
        public Node Next { get; set; }

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }

    }
}
