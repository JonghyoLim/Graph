using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGraphForm
{
    public abstract class Heap : IPriorityQueue
    {
        protected IComparable[] elements;
        protected int lastIndex;
        protected int maxIndex;


        protected Heap()
        {
            elements = new IComparable[Int16.MaxValue];
            lastIndex = -1;
            maxIndex = Int16.MaxValue - 1;
        }

        #region Implementation of IPriorityQueue

        public void enqueue(IComparable item)
        {
            if (lastIndex == maxIndex)
                throw new Exception("Priority queue is full");
            lastIndex = lastIndex + 1;
            reheapUp(item);
        }

        public IComparable dequeue()
        {
            if (lastIndex == -1)
                throw new Exception("Priority queue is empty");
            IComparable hold = elements[0]; // element to be dequeued
            IComparable toMove = elements[lastIndex]; //item to reheap down
            lastIndex = lastIndex - 1;
            reheapDown(toMove);
            return hold;
        }

        public bool isEmpty()
        {
            return (lastIndex == -1);
        }

        public bool isFull()
        {
            return (lastIndex == maxIndex);
        }

        #endregion

        protected void reheapDown(IComparable item)
        {
            int hole = 0; //current index of hole
            int newhole; //new location of hole

            newhole = newHole(hole, item);
            while (hole != newhole)
            {
                elements[hole] = elements[newhole]; // move element up
                hole = newhole; // move hole down
                newhole = newHole(hole, item); //get next hole
            }

            elements[hole] = item; //fill final hole with item
        }

        protected abstract void reheapUp(IComparable item);
        protected abstract int newHole(int hole, IComparable item);

    }


    public class MinHeap : Heap
    {
        #region Overrides of Heap

        protected override void reheapUp(IComparable item)
        {
            int hole = lastIndex; // initial insertion location

            while (hole > 0 && item.CompareTo(elements[(hole - 1) / 2]) < 0) //MIN HEAP
                                                                             // if hole is not the root and item is greater than its parent value
            {
                elements[hole] = elements[(hole - 1) / 2]; // move parent to hole 
                hole = (hole - 1) / 2; // move hole up
            }

            elements[hole] = item; // place item into final hole.
        }


        protected override int newHole(int hole, IComparable item)
        {
            int left = (hole * 2) + 1; //left child
            int right = (hole * 2) + 2; //right child

            if (left > lastIndex)
                return hole; // hole has no childerns
            if (left == lastIndex) // hole has left child only
                if (item.CompareTo(elements[left]) > 0)
                    return left; //item is less than left child
                else
                    return hole; // item  >= right child
            if (elements[left].CompareTo(elements[right]) > 0) // left child > right child
                if (elements[right].CompareTo(item) > 0)
                    return hole; // right child <= item
                else
                    return right; // item < right child

            if (elements[left].CompareTo(item) > 0)
                return hole; // left child <= item
            else
                return left; // item < left child
        }

        #endregion

        public void changeRoot(IComparable x)
        {
            IComparable root = elements[0];
            if (root.CompareTo(x) < 0)
            {
                dequeue();
                enqueue(x);
            }
        }
    }

}
