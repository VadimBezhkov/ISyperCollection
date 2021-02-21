using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            MySyperList MyCollection = new MySyperList();
            MyCollection.Add(new MySuperCollection("Alexsey",3,5));
            MyCollection.Add(new MySuperCollection("Vadim",5,4));
            MyCollection.Add(new MySuperCollection("Pavel",1,2));
            MyCollection.Add(new MySuperCollection("Timofey", 9, 8));
            MyCollection.Add(new MySuperCollection("Ivan", 4, 8));
            MyCollection.Remove(2);
            MyCollection.Remove("Ivan");
            IEnumerable enumerable = MyCollection as IEnumerable;
            IEnumerator enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                MySuperCollection myIndex = enumerator.Current as MySuperCollection;
                if(myIndex!=null)
                Console.WriteLine("Name {0}, Fild1 {1}, Fild2 {2}", myIndex.Name, myIndex.Fild1, myIndex.Fild2);
            }

            Console.ReadKey();
        }
    }
}
