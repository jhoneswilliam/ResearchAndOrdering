using System.Collections.Generic;
using System.Linq;

namespace ResearchAndOrdering.Graph
{
      class Simplex<Estructure> where Estructure : MatrixAdjacency
    {
        public Graph<Estructure> Graph { get; set; }

        public Simplex(Graph<Estructure> graph)
        {
            Graph = graph;
        }

        public LinkedList<int> run(int verticeStart, int verticeEnd)
        {
            Queue<LinkedList<int>> queueRouter = new Queue<LinkedList<int>>();
            LinkedList<int> fistRouter = new LinkedList<int>();
            fistRouter.AddLast(verticeStart);
            queueRouter.Enqueue(fistRouter);

            //visited[verticeStart] = true;

            while (queueRouter.Count > 0)
            {
                LinkedList<int> router = queueRouter.Dequeue();
                int verticeP = router.Last();
                for (int verticeD = 0; verticeD < Graph.VerticeCount(); verticeD++)
                {
                    if (verticeP != verticeD && router.Contains(verticeD) == false && Graph.GraphEstructure.Matrix[verticeP, verticeD] > 0)
                    {   
                        router.AddLast(verticeD);
                        if (verticeEnd == verticeEnd)
                        {
                            return router;
                        }
                        else
                        {   
                            queueRouter.Enqueue(router);
                        }
                    }
                }
            }
            return null;
        }
    }
}
