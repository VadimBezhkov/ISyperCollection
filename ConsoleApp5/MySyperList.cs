using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class MySyperList : IEnumerator, IEnumerable

    {
        public MySuperCollection[] collectionsArray; 
        
        int position = -1;
     
        public MySyperList()
        {
            collectionsArray = new MySuperCollection[5];
        }
        public object Current
        {
            get { return collectionsArray[position]; }
        }
        public void Remove(int index)
        {
            collectionsArray[index] = null;
        }
        public void Add(MySuperCollection item)
        {
          collectionsArray[collectionsArray.Count(i=>i!=null)] = item;
        }

        public bool MoveNext()
        {
            if (position < collectionsArray.Length - 1)
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
