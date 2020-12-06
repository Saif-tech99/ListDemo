using ListDemo.Iterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo.Models
{
    public class Liist:IList
    {
        private readonly int[] _array;
        private readonly int _size;

        public Liist(int size)
        {
            _size = size;
            _array = new int[size];
        }

        public void DeletElamentAtIndex(int index)
        {
            if (index < 0 || index >= _size)
            {
                Console.WriteLine("out of range");
            }
            else
            {
                _array[index] = -999;
            }
        }

        public int GetElimentAtIndex(int index)
        {
            if (index < 0 || index >= _size)
            {
                Console.WriteLine("out of range");
                return -999;
            }
            else
            {
                return _array[index];
            }
        }

        public void InsertAtIndex(int elament, int index)
        {
            if (index < 0 || index >= _size)
            {
                Console.WriteLine("out of range");
            }
            else
            {
                _array[index] = elament;
            }
        }

        public void PrintEliment()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }
    }
}
