using ResearchAndOrdering.Graph;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ResearchAndOrdering.Teste
{
    class GraphTeste
    {
        public static string Simplex()
        {
            int verticeStart = 0;
            int verticeEnd = 2;

            MatrixAdjacency matrixIncidence = new MatrixAdjacency(5);
            matrixIncidence.AddEdge(0, 2);
            //matrixIncidence.AddEdge(0, 1);
            //matrixIncidence.AddEdge(1, 3);
            //matrixIncidence.AddEdge(3, 4);

            matrixIncidence.ToConsole();

            Graph<MatrixAdjacency> graph = new Graph<MatrixAdjacency>(matrixIncidence);
            LinkedList<int> router = new Simplex<MatrixAdjacency>(graph).run(verticeStart, verticeEnd);
            Console.WriteLine("==============================================");
            if (router != null)
            {
                Console.WriteLine("::EURECA:::");
                while (router.Count > 0)
                {
                    Console.Write(string.Format(" -> vertice[{0}]", router.First()));
                    router.RemoveFirst();
                }
            }
            else
            {
                Console.WriteLine("DON'T CRY");
            }

            Console.ReadKey();

            return "";
        }



        //Simple simples = new Simple();
    }
}
