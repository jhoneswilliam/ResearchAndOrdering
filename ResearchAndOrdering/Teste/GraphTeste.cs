using ResearchAndOrdering.Graph;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ResearchAndOrdering.Teste
{
    class GraphTeste
    {
        public static string Simple()
        {

            int verticeStart = 0;
            int verticeEnd = 3;

            MatrixIncidence matrixIncidence = new MatrixIncidence(5, 4);
            matrixIncidence.AddEdge(0, 1);
            matrixIncidence.AddEdge(0, 2);

            matrixIncidence.AddEdge(2, 4);
            matrixIncidence.AddEdge(4, 3);
            
            matrixIncidence.ToConsole();
            Graph<MatrixIncidence> graph = new Graph<MatrixIncidence>(matrixIncidence);
            LinkedList<int> router = new Simple<MatrixIncidence>(graph).run(verticeStart, verticeEnd);
            Console.WriteLine("==============================================");
            if(router != null)
            {
                Console.WriteLine("::EURECA:::");
                while(router.Count > 0)
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
