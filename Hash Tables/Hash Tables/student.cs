using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Tables
{
    internal class student
    {
        public string Namn { get; set; }
        public int Id { get; set; }
        public string Programm { get; set; }

        public student(string namn, int id, string programm)
        {
            Namn = namn;
            Id = id;
            Programm = programm;
        }
    }
}
