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
            MyCollection.Add("LastName");
            MyCollection.Add("FirstName");
            MyCollection.Add("Age");
            MyCollection.Add("Gender");
            IEnumerable enumerable = MyCollection as IEnumerable;
            IEnumerator enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                String myIndex = enumerator.Current as String;
                Console.WriteLine(myIndex);
            }
            enumerator.Reset();

            Console.ReadKey();
        }
    }
}
