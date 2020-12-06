using ListDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Liist liist = new Liist(5);
            liist.InsertAtIndex(0, 2);
            liist.InsertAtIndex(1, 1);
            liist.InsertAtIndex(4, 1);
            liist.PrintEliment();

        }
    }
}
