using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Conditional_Operator
{
    internal class Program
    {
        static int[]GetArray()
        {
            int[] myArray = { 1, 2, 3 };
            //int[] myArray = null;
            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            Console.WriteLine("Сумма элементов массива: " + (myArray?.Sum() ?? 0));
        }
    }  
}
