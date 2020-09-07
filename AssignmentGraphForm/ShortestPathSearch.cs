using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AssignmentGraphForm
{
    public class ShortestPathSearch
    {
        internal class Flights : IComparable
        {
            public int Distance { get; set; }
            public object FromVertex { get; set; }
            public object ToVertex { get; set; }

    
            public int CompareTo(object otherFlights)
            {
                var other = (Flights)otherFlights;
                return (other.Distance - Distance);
            }

        }

 /// <summary>
 /// //////////////////////////////////////////////////////////////////////////////////////////////
 /// </summary>
        private readonly IWeightedGraph graph;

        //COnstructor
        public ShortestPathSearch(IWeightedGraph graph)
        {
            this.graph = graph;
        }

        
        public void printShortestPath(object startVertex)
        {
            shortestPathSearch(startVertex);
        }


        private void shortestPathSearch(object startVertex)
        {
            Flights item;
            Flights saveItem;
            int minDistance;
            Queue<object> vertextQ = new Queue<object>();
            IPriorityQueue pq = new MinHeap();
            object vertex;
           //int count = 0;

            graph.ClearMarks();
            saveItem = new Flights
            {
                FromVertex = startVertex,
                ToVertex = startVertex,
                Distance = 0
            };

            pq.enqueue(saveItem);

            Console.WriteLine("Last Vertex  Destination  Distance");
            Console.WriteLine("-----------------------------------");

            do
            {
                item = (Flights)pq.dequeue();

                if (!graph.IsMarked(item.ToVertex))
                {
                    graph.MarkVertex(item.ToVertex);
                    Console.Write(item.FromVertex);
                    Console.Write("  ");
                    Console.Write(item.ToVertex);
                    Console.WriteLine("   " + item.Distance);
                    item.FromVertex = item.ToVertex;
                    minDistance = item.Distance;
                    vertextQ = graph.GetToVertices(item.FromVertex);

                    while (vertextQ.Count > 0) // IsEmpty() 
                    {
                        vertex = vertextQ.Dequeue(); // has to use unsighned local variable
                        if (!graph.IsMarked(vertex))
                        {
                            saveItem = new Flights
                            {
                                FromVertex = item.FromVertex,
                                ToVertex = vertex,
                                Distance = minDistance + graph.WeightIs(item.FromVertex, vertex)
                            };
                            pq.enqueue(saveItem);
                        }
                    }
                }
            } while (!pq.isEmpty());
        }

      



    }


}

