using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndOrdering.Graph
{
    class Simple<Estructure> where Estructure : MatrixIncidence
    {
        public Graph<Estructure> Graph { get; set; }
        public LinkedList<int> Router { get; set; }

        public Simple(Graph<Estructure> graph) {
            Graph = graph;
            Router = new LinkedList<int>();
        }

        public string run() => run(0);

        public string run(int verticeStart) => run(verticeStart, string.Format(" -> Vertice[{0}]", verticeStart));

        public string run(int verticeStart, string router)
        {            
            if (Router.Contains(verticeStart)) return router;

            
            
            for (int edges = 0; edges < Graph.GraphEstructure.EdgesCount(); edges++)
            {
                if (Graph.GraphEstructure.Matrix[verticeStart, edges] > 0)
                {
                    for (int vertice = 0; vertice < Graph.GraphEstructure.VerticeCount(); vertice++)
                    {
                        if (Graph.GraphEstructure.Matrix[vertice, edges] > 0)
                        {                            
                            edges = Graph.GraphEstructure.EdgesCount();
                            return run(vertice, router + string.Format(" -> Vertice[{0}]", vertice));
                        }
                    }
                }
            }

            return router;
        }
    }
}
