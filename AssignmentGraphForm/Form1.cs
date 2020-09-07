using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentGraphForm
{

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
       static WeightedGraph graph = new WeightedGraph();
       static DepthFirstSearch dfs = new DepthFirstSearch(graph);
        static ShortestPathSearch sFs = new ShortestPathSearch(graph);

        public Form1()
        {

            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddFlight_Click(object sender, EventArgs e)
        {

            object d = departureTexBox.Text;
            object a = arrivalTexBox.Text;

            if (graph.FindAirPort(d) == false)
            {
                graph.AddVertex(d);
            
            }

            if (graph.FindAirPort(a) == false)
            {
                graph.AddVertex(a);
           
            }

            int start = 0;
            int end = 0;

            start = graph.IndexIs(d);
            end = graph.IndexIs(a);
            if (graph.edges[start, end] == 0)
            {
                graph.AddEdge(d, a, Convert.ToInt32(distanceTexbox.Text));
                listBox2.Items.Add("Route added !!");
            }

            else
            {
                listBox2.Items.Add("Route is already existed");
            }

            listBox1.Items.Clear();  // Otherwise duplicate List items.
            foreach (var flight in graph.DisplayAllRoutes())
            {
                listBox1.Items.Add(flight);
            }
           
        }

        private void SearchFlight_Click(object sender, EventArgs e)
        {
            string d = departureTexBox.Text;
            string a = arrivalTexBox.Text;
            List<string> Search = dfs.search(graph, d, a);

            if (Search == null)
            {
                listBox2.Items.Add("Sorry No Routes is exist");
            }

            else
            {
                listBox2.Items.Clear();
                foreach (string s in Search) {
                    listBox2.Items.Add(s);
                }
            }
        }

        private void FormListAllFlights_Load(object sender, EventArgs e)
        {

            graph.AddVertex("Atlanta");
            graph.AddVertex("Austin");
            graph.AddVertex("Chicago");
            graph.AddVertex("Dallas");
            graph.AddVertex("Denver");
            graph.AddVertex("Houston");
            graph.AddVertex("Washington");

            graph.AddEdge("Atlanta", "Washington", 600);

            graph.AddEdge("Austin", "Dallas", 200);
            graph.AddEdge("Austin", "Houston", 160);

            graph.AddEdge("Chicago", "Denver", 1000);

            graph.AddEdge("Dallas", "Austin", 200);
            graph.AddEdge("Dallas", "Chicago", 900);
            graph.AddEdge("Dallas", "Denver", 780);

            graph.AddEdge("Denver", "Atlanta", 1400);
            graph.AddEdge("Denver", "Chicago", 1000);

            graph.AddEdge("Houston", "Atlanta", 800);

            graph.AddEdge("Washington", "Atlanta", 600);
            graph.AddEdge("Washington", "Dallas", 1300);
            
            foreach (var flight in graph.DisplayAllRoutes())
            {
                listBox1.Items.Add(flight);
            }
                    
        }

        private void DeleteFlight_Click(object sender, EventArgs e)
        {
            object d = departureTexBox.Text;
            object a = arrivalTexBox.Text;

            int startVertex = 0;
            int endVertex = 0;

            startVertex = graph.IndexIs(d);
            endVertex = graph.IndexIs(a);

            if (graph.edges[startVertex , endVertex] != 0)
            {
                graph.DeleteEdge(d, a);
                listBox1.Items.Clear();
                foreach (var flight in graph.DisplayAllRoutes())
                {
                 
                    listBox1.Items.Add(flight);
                }
            }

        }
    }
}
