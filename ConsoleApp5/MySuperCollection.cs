using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   public sealed class MySuperCollection
    {
        private string name;
        public DateTime MyData { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int fild1;

        public int Fild1
        {
            get { return fild1; }
            set { fild1 = value; }
        }
        private int fild2;

        public int Fild2
        {
            get { return fild2; }
            set { fild2 = value; }
        }
        public MySuperCollection()
        {

        }
        public MySuperCollection(string _name,int _fild1, int _fild2)
        {
            Name = _name;
            Fild1 = _fild1;
            Fild2 = _fild2;
        }
    }
}
