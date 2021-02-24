using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5;

namespace ExtentionMy
{
    static class MyExtention
    {
        // display of the current date and time
        public static void Print(this DateTime date)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{date} \n");
            Console.ResetColor();
        }

        //Sorting my collection
        public static void MySort(this MySuperCollection[] collectionsArray)
        {
            MySuperCollection[] temp = new MySuperCollection[collectionsArray.Length];
            for (int j = 0; j < collectionsArray.Length - 1; j++)
            {
                for (int i = 0; i < collectionsArray.Length - 1; i++)
                {
                    if (collectionsArray[i].Name.Length > collectionsArray[i + 1]?.Name.Length)
                    {
                        temp[i] = collectionsArray[i];
                        collectionsArray[i] = collectionsArray[i + 1];
                        collectionsArray[i + 1] = temp[i];
                    }
                }
            }
        }
    }
}
