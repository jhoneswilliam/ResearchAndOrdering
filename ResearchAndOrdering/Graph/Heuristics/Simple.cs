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
        //public Queue<LinkedList<int>> QueueRouter { get; set; }

        public Simple(Graph<Estructure> graph)
        {
            Graph = graph;
            //QueueRouter = new Queue<LinkedList<int>>();
        }

        public LinkedList<int> run(int verticeStart, int verticeEnd)
        {
            LinkedList<int> router = new LinkedList<int>();
            router.AddLast(verticeStart);

            Queue<LinkedList<int>> queueRouter = new Queue<LinkedList<int>>();
            queueRouter.Enqueue(router);

            return run(queueRouter, verticeEnd);
        }

        public LinkedList<int> run(Queue<LinkedList<int>> queueRouter, int verticeEnd)
        {
            LinkedList<int> possibleRouter;

            while (queueRouter.Count > 0)
            {
                possibleRouter = queueRouter.Dequeue();
                int lastVertice = possibleRouter.Last();

                for (int edge = 0; edge < Graph.EdgesCount(); edge++)
                {
                    if (Graph.GraphEstructure.Matrix[lastVertice, edge] > 0)
                    {
                        for (int vertice = 0; vertice < Graph.VerticeCount(); vertice++)
                        {
                            if (Graph.GraphEstructure.Matrix[vertice, edge] > 0 && possibleRouter.Contains(vertice) == false)
                            {
                                possibleRouter.AddLast(vertice);

                                if (vertice == lastVertice)
                                {
                                    return possibleRouter;
                                }
                                else
                                {
                                    queueRouter.Enqueue(possibleRouter);
                                }
                                vertice = Graph.VerticeCount();
                                edge = Graph.EdgesCount();
                            }
                        }
                    }
                }
            }
            return null;
        }

        //public LinkedList<int> run(int verticeStart, int verticeEnd, string tehs)
        //{
        //    for (int edge = 0; edge < Graph.EdgesCount(); edge++)
        //    {
        //        if(Graph.GraphEstructure.Matrix[verticeStart, edge] > 0)
        //        {
        //            for (int vertice = 0; vertice < Graph.VerticeCount(); vertice++)
        //            {
        //                if(Graph.GraphEstructure.Matrix[vertice, edge] > 0)
        //                {
        //                    LinkedList<int> possibleRouter = new LinkedList<int>(router);
        //                    possibleRouter.AddLast(vertice);
        //                    QueueRouter.Enqueue(possibleRouter);

        //                    vertice = Graph.VerticeCount();
        //                    edge = Graph.EdgesCount();
        //                }
        //            }
        //        }
        //    }



        //    return run(router, verticeEnd);
        //}


    }
}
