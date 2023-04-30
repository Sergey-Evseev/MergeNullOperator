using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MergeNullOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            str ??= string.Empty;

            Console.WriteLine($"Количество символов в строке: {str.Length}");
        }
    }
}








