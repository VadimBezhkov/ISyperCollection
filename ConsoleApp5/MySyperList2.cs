using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public partial class MySyperList
    {
        //delete by index my collection item
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
                    tempArray[i - indexarray] = collectionsArray[i];
                else
                {
                    indexarray++;
                    {
                        try
                        {
                            if (_mes != null && collectionsArray[index] != null)
                                Console.ForegroundColor = ConsoleColor.Blue;
                            _mes($"object deleted {collectionsArray[index].Name} {collectionsArray[index].Fild1} {collectionsArray[index].Fild2} idex {index}");
                            Console.ResetColor();
                        }
                        catch (NullReferenceException)
                        {
                            break;
                        }
                    }
                }
            }
            collectionsArray = tempArray;
        }

        //delete by name my collection item
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

            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }

    }
}
