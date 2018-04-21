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
            int verticeEnd = 4;

            MatrixAdjacency matrixIncidence = new MatrixAdjacency(5);
            matrixIncidence.AddEdge(0, 2);
            matrixIncidence.AddEdge(0, 1);
            matrixIncidence.AddEdge(1, 3);
            matrixIncidence.AddEdge(3, 4);


            //matrixIncidence.AddEdge(0, 1);
            //matrixIncidence.AddEdge(1, 4);
            //matrixIncidence.AddEdge(0, 2);
            //matrixIncidence.AddEdge(2, 3);
            //matrixIncidence.AddEdge(3, 4);



            //matrixIncidence.ToConsole();
            LinkedList<int> router = new Simplex(matrixIncidence).run(verticeStart, verticeEnd);
            Console.WriteLine("==============================================");
            Console.WriteLine(router.ToString());

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
