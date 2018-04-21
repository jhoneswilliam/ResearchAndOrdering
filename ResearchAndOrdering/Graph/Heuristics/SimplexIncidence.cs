using System.Collections.Generic;
using System.Linq;

namespace ResearchAndOrdering.Graph
{
    public class Simplex
    {
        public MatrixAdjacency Graph { get; set; }

        public Simplex(MatrixAdjacency graph)
        {
            Graph = graph;
        }

        public LinkedList<int> run(int verticeStart, int verticeEnd)
        {
            Queue<LinkedList<int>> queueRouter = new Queue<LinkedList<int>>();
            LinkedList<int> fistRouter = new LinkedList<int>();
            fistRouter.AddLast(verticeStart);
            queueRouter.Enqueue(fistRouter);

            while (queueRouter.Count > 0)
            {
                LinkedList<int> router = queueRouter.Dequeue();
                int verticeWalkStart = router.Last();
                for (int verticeWalkEnd = 0; verticeWalkEnd < Graph.VerticeCount(); verticeWalkEnd++)
                {
                    if (verticeWalkStart != verticeWalkEnd && router.Contains(verticeWalkEnd) == false && Graph.Matrix[verticeWalkStart, verticeWalkEnd] > 0)
                    {
                        LinkedList<int> newRouter = new LinkedList<int>(router);
                        newRouter.AddLast(verticeWalkEnd);
                        if (verticeEnd == verticeWalkEnd)
                        {
                            return newRouter;
                        }
                        else
                        {
                            queueRouter.Enqueue(newRouter);
                        }
                    }
                }
            }
            return null;
        }
    }
}
