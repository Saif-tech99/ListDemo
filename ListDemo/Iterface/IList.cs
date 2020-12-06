using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo.Iterface
{
    public interface IList
    {
        void InsertAtIndex(int elament, int index);
        int GetElimentAtIndex(int index);
        void PrintEliment();
        void DeletElamentAtIndex(int index);
    }
}
