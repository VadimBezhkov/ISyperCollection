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
    // create partion class
    public partial class MySyperList : IEnumerator, IEnumerable
    {
        // create My Delegate
        public delegate void MyDelegate(string text);
        
        public MySuperCollection[] collectionsArray;

        //declare a variable my delegate
        MyDelegate _mes;
        // variable position
        int position = -1;

        //registration delegate
        public void RegisterDelegate(MyDelegate mes)
        {
            _mes = mes;
        }
        //create static constructor
        static MySyperList()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hi alexey glad to welcome you to my homework." +
                " \nI hope for loyalty and understanding" + "\n");
            Console.ResetColor();
        }
        // create my collection
        public MySyperList()
        {
            collectionsArray = new MySuperCollection[1];
        }

        public object Current
        {
            get { return collectionsArray[position]; }
        }

        // add item my collection
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

        //method next position my coleection
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

        //reset position
        public void Reset()
        {
            position = -1;
        }

       // returning a link to myself
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

    }
}
