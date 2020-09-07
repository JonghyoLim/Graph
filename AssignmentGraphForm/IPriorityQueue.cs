using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGraphForm
{
    public interface IPriorityQueue
    {

        void enqueue(IComparable item);
        IComparable dequeue();
        bool isEmpty();
        bool isFull();
    }
}
