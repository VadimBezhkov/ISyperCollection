using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtentionMy;

namespace ConsoleApp5
{
    public partial class MySyperList : IEnumerator, IEnumerable

    {
        public delegate void MyDelegate(string text);
        public MySuperCollection[] collectionsArray;

        MyDelegate _mes;
        int position = -1;
        public void RegisterDelegate(MyDelegate mes)
        {
            _mes = mes;
        }
        static MySyperList()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hi alexey glad to welcome you to my homework." +
                " \nI hope for loyalty and understanding" + "\n");
            Console.ResetColor();
        }
        public MySyperList()
        {
            collectionsArray = new MySuperCollection[1];
        }

        public object Current
        {
            get { return collectionsArray[position]; }
        }

        public void Add(MySuperCollection item)
        {
            collectionsArray[collectionsArray.Count(i => i != null)] = item;
            int value = collectionsArray.Length + 1;
            MySuperCollection[] tempArray = new MySuperCollection[value];

            for (int i = 0; i <= collectionsArray.Length - 1; i++)
            {
                tempArray[i] = collectionsArray[i];
            }

            collectionsArray = tempArray;
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
