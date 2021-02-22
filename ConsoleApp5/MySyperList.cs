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
         static MySyperList()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hi alexey glad to welcome you to my homework." +
                " \nI hope for loyalty and understanding" + "\n");
            Console.ResetColor();
        }

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
            //collectionsArray[index] = new MySuperCollection ("",0,0);
            //collectionsArray[index] = null;
            int value = collectionsArray.Length;
            if (value > 1)
                value--;
            else
                Console.WriteLine("Error array less than 2 elements could not be created");
            MySuperCollection[] tempArray = new MySuperCollection[value];
            int indexarray = 0;
            for (int i = 0; i < collectionsArray.Length; i++)
            {
                if (i != index)
                    tempArray[i- indexarray] = collectionsArray[i];
                else
                    indexarray++;

            }
            collectionsArray = tempArray;
        }

        public void Remove(string text)
        {
            try
            {
                var parenname = collectionsArray.FirstOrDefault(x => x.Name == text);
                for (int i = 0; i < collectionsArray.Length; i++)
                {
                    if (collectionsArray[i] == parenname)
                        Remove(i);
                        //collectionsArray[i] = null;
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("One of the array elements is empty");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
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
