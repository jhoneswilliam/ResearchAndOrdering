using ResearchAndOrdering.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndOrdering.View
{
    public class MatrixIncidenceToConsole
    {
        public MatrixIncidenceToConsole(MatrixIncidence matrixIncidence)
        { 
            Console.Write("\t");
            Console.Write("|");
            Console.Write("\t");


            for (int edges = 0; edges < matrixIncidence.EdgesCount(); edges++)
            {
                Console.Write(String.Format("A{0}", edges));
                Console.Write("\t");
            }

            Console.WriteLine("|");


            for (int vertice = 0; vertice < matrixIncidence.VerticeCount(); vertice++)
            {
                Console.Write(String.Format("V{0}", vertice));
                Console.Write("\t");
                Console.Write("|");
                Console.Write("\t");
                for (int edges = 0; edges < matrixIncidence.EdgesCount(); edges++)
                {
                    Console.Write(matrixIncidence.Matrix[vertice, edges]);
                    Console.Write("\t");
                }
                Console.WriteLine("|");
            }
        }
    }
}
