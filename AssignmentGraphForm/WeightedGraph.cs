using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AssignmentGraphForm
{
    public class WeightedGraph : IWeightedGraph
    {

        public static int NULL_EDGE;
        public readonly int[,] edges;
        private readonly bool[] marks;
        private readonly int maxVertices;
        public readonly object[] vertices;
        private int numVertices;

        public WeightedGraph()
        {
            numVertices = 0;
            maxVertices = 50;
            vertices = new object[50]; //  new VertexType[50]; coz can not implicitly convert
            marks = new bool[50];
            edges = new int[50, 50];
            /*
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i] = string.Empty;
            }
            */
        }

        public WeightedGraph(int maxV)
        {
            numVertices = 0;
            maxVertices = maxV;
            vertices = new object[maxV];
            marks = new bool[maxV];
            edges = new int[maxV, maxV];
        }


        public void DeleteEdge(object fromVertex, object toVertex)
        {
            int row, col;

            row = IndexIs(fromVertex);
            col = IndexIs(toVertex);

            edges[row, col] = 0;

        }

        public List<string> DisplayAllRoutes()
        {
            List<string> routes = new List<string>();

            foreach (var fromVertex in vertices)
            {
                foreach (var toVertex in vertices)
                {
                    int weight =0;
                    if (fromVertex != null && toVertex != null)
                        weight = WeightIs(fromVertex, toVertex);

                    if (weight != 0)
                        routes.Add(String.Format("{0,-14}\tTO\t{1,-25}\t{2,-5} ", fromVertex, toVertex, weight));
                }
            }

            return routes;
        }

    


   
        public bool FindAirPort(object Vertex)
        {
            for(int i = 0;i<numVertices; i++ )
            {
                if (vertices[i].ToString() == Vertex.ToString())
                {
                    return true;
                }
            }
            return false;
        }

     public int IndexIs(object vertex)
        {
      
            int index = 0;
            while (!(vertex.ToString() == vertices[index].ToString()))
               index++;

            return index;
        }

        #region IWeightedGraph

        public void AddVertex(object vertex)
        {
            vertices[numVertices] = vertex;
            for(int index=0; index<numVertices; index++)
            {
                edges[numVertices, index] = NULL_EDGE;
                edges[index, numVertices] = NULL_EDGE;
            }
            numVertices++;


        }

     

        public void AddEdge(object fromVertex, object toVertex, int weight)
        {
            int row, col;

            row = IndexIs(fromVertex);
            col = IndexIs(toVertex);

            edges[row, col] = weight;

        }


        public int WeightIs(object fromVertex, object toVertex)
        {
            int row, col;
            row = IndexIs(fromVertex);
            col = IndexIs(toVertex);
            return edges[row,col];
        }

        
        public Queue<object> GetToVertices(object vertex)
        {
            Queue<object> adjVertices = new Queue<object>();
            int fromIndex = IndexIs(vertex);

            for (int toIndex = 0; toIndex < numVertices; toIndex++)
            {
                if (edges[fromIndex, toIndex] != NULL_EDGE)
                    adjVertices.Enqueue(vertices[toIndex]);
            }
            return adjVertices;
        }
        
  


        public void MakeEmpty()
        {
            // Function: Initialize graph to the empty state.
            // Post: Graph is empty.
            Array.Clear(vertices, 0, vertices.Length);
            Array.Clear(edges, 0, edges.Length);
          

        }

        public bool IsEmpty()
        {
            // Function: Initialize graph to the empty state.
            // Post: Graph is empty.

            return numVertices == 0;
        }

        public bool IsFull()
        {
            // Function: Determines if the graph is full.
            // Post: Function value = (graph is full). 

            return maxVertices == numVertices;
        }

        public void ClearMarks()
        {
            // Function: Sets marks for all vertices to 	// false.
            // Post:  All makrs have been set to false.

            for (int i=0; i< numVertices; i++)
            {
                marks[i] = false;
            }
        }


        public void MarkVertex(object vertex)
        {
            // Function: Sets mark for vertex to true.
            // Pre:  vertex is in V(graph).
            // Post: IsMarked(vertex) is true.
            int index = IndexIs(vertex);

            if (!IsMarked(vertex))
            {
                marks[index] = true;
            }
        }


        public bool IsMarked(object vertex)
        {
            // Function: Determines if vertex has been 	// marked.
            // Pre:  vertex is in V(graph).
            // Post: Function value = (vertex is marked 	// true)
            int index = IndexIs(vertex);
            return marks[index];
        }


     

        #endregion



    }
}
