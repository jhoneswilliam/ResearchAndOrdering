using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndOrdering.Graph
{
    public class Graph<Estructure> : IGraphEstructure where Estructure : IGraphEstructure
    {
        public Estructure GraphEstructure { get; set; }

        public Graph(Estructure graphEstructure) => GraphEstructure = graphEstructure;        

        public void AddEdge(int vertice1, int vertice2) => GraphEstructure.AddEdge(vertice1, vertice2);

        public void AddVertice() => GraphEstructure.AddVertice();

        public int VerticeCount() => GraphEstructure.VerticeCount();

        public int EdgesCount() => GraphEstructure.EdgesCount();
    }
}
