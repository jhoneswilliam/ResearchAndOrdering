using ResearchAndOrdering.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndOrdering.View
{
    public class MatrixAdjacencyToConsole
    {
        public MatrixAdjacencyToConsole(MatrixAdjacency matrixAdjacency)
        {
            Console.Write("\t");
            Console.Write("|");
            Console.Write("\t");


            for (int vertice = 0; vertice < matrixAdjacency.VerticeCount(); vertice++)
            {
                Console.Write(String.Format("V{0}", vertice));
                Console.Write("\t");
            }

            Console.WriteLine("|");


            for (int vertice = 0; vertice < matrixAdjacency.VerticeCount(); vertice++)
            {
                Console.Write(String.Format("V{0}", vertice));
                Console.Write("\t");
                Console.Write("|");
                Console.Write("\t");
                for (int verticel = 0; verticel < matrixAdjacency.VerticeCount(); verticel++)
                {
                    Console.Write(matrixAdjacency.Matrix[vertice, verticel]);
                    Console.Write("\t");
                }
                Console.WriteLine("|");
            }
        }
    }
}
