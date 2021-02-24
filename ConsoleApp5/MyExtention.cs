using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMy
{
    static class MyExtention
    {
        public static void Print(this DateTime date)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{date} \n");
            Console.ResetColor();
        }
    }
}
