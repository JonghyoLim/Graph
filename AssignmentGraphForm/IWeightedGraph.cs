using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AssignmentGraphForm
{
   public interface IWeightedGraph
    {
        //private class same like C++
        bool IsEmpty();
        bool IsFull();
        void AddVertex(object vertex);
        void AddEdge(object fromVertex, object toVertex, int weight);
        void ClearMarks();
        void MarkVertex(object vertex);
        bool IsMarked(object vertex);
        int WeightIs(object fromVertex, object toVertex);
        Queue<object> GetToVertices(object vertex);
    }
}
