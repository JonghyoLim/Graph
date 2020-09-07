using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AssignmentGraphForm
{
    public class DepthFirstSearch
    {
        private readonly IWeightedGraph graph;

        public DepthFirstSearch(IWeightedGraph graph)
        {
            this.graph = graph;
        }


        public List<string> search(IWeightedGraph graph, object startVertex, object endVertex)
        {
            return depthFirstSearch(graph, startVertex, endVertex);
        }

      //  public List<string> delete(IWeightedGraph graph, object startVertex, object endVertex)
       // {
       //     return depthFirstSearch(graph, startVertex, endVertex);
      //  }



        public List<string> depthFirstSearch( IWeightedGraph graph, object startVertex, object endVertex)
        {
            Stack<object> stack = new Stack<object>(); //string cant work
            Queue<object> vertexQ = new Queue<object>();
            bool found = false;
            object vertex;
            object item;

            List<string> allRoute = new List<string>();
           // List<string> deleteRoute = new List<string>();

            graph.ClearMarks();
            stack.Push(startVertex);

            do
            {
                vertex = stack.Pop();

                if (vertex.ToString() == endVertex.ToString())
                { // general case when path is found
                    found = true;
                    allRoute.Add(vertex.ToString());
                }
                else
                {
                    if (!graph.IsMarked(vertex)) // if not marked
                    {
                        graph.MarkVertex(vertex); // then mark that vertex
                        allRoute.Add(vertex.ToString());

                        vertexQ = graph.GetToVertices(vertex); //get all adjecent vertexes

                        while (vertexQ.Count > 0)// Queue does not contain IsEmpty // then for each of those adjecent vertexes
                        {
                            item = vertexQ.Dequeue(); // vertextQ.Dequeue(item) item has to be removed and from Queue
                            if (!graph.IsMarked(item))
                                stack.Push(item);
                        }
                    }
                }
            } while (stack.Count > 0 && !found); //instead of stack.IsEmpty()

            if (!found)
                allRoute = null;

            return allRoute;

            
        }
    }
}
