using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class MySyperList : IEnumerator,IEnumerable

    {
        private string [] _data;
        int position = -1;
     
        public MySyperList()
        {
            _data = new string[5];
        }
        public object Current
        {
            get { return _data[position]; }
        }

        public void Add(string item)
        {
           var corentIndex =_data[_data.Count(i=>i!=null)] = item;
        }

        public bool MoveNext()
        {
            if (position < _data.Length - 1)
            {
                position++;
                return true;
            }
            else
                Reset();
                return false;
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

    }
}
