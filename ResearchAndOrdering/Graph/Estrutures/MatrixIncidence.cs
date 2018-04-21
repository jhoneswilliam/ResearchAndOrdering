using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndOrdering.Graph
{
    public class MatrixIncidence : IGraphEstructure
    {
        public int[,] Matrix { get; set; }
        public int EdgesAmmount = 0;

        public int VerticeCount() => Matrix.GetLength(0);

        public int EdgesCount() => EdgesAmmount;

        public MatrixIncidence(int[,] matriz) => Matrix = matriz;

        public MatrixIncidence(int ammountVertices, int ammountEdges)
        {
            Matrix = new int[ammountVertices, ammountEdges];
        }

        public void AddEdge(int vertice1, int vertice2)
        {
            Matrix[vertice1, EdgesAmmount]++;
            Matrix[vertice2, EdgesAmmount]++;
            EdgesAmmount++;
        }

        public void AddVertice()
        {
            Matrix = new int[this.VerticeCount() + 1, this.EdgesAmmount];
        }
    }
}
