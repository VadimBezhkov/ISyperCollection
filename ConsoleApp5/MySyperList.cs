using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class MySyperList : IEnumerable, IEnumerator
    {
        private string[] _data;
        public MySyperList()
        {
            _data = new string[5];
        }

        public object Current => throw new NotImplementedException();

        public void Add(string item)
        {
           var corentIndex =_data[_data.Count(i=>i!=null)] = item;
        }
        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
