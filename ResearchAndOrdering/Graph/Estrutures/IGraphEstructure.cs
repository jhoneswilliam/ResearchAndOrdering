using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndOrdering.Graph
{
    public interface IGraphEstructure
    {
        void AddEdge(int vertice1, int vertice2);
        void AddVertice();
        int VerticeCount();
        int EdgesCount();
    }
}
