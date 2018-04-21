using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndOrdering.Graph
{
    public class MatrixAdjacency : IGraphEstructure
    {
        public int[,] Matrix { get; set; }
        public int EdgesAmmount = 0;

        public int VerticeCount() => Matrix.GetLength(0);

        public int EdgesCount() => EdgesAmmount;

        public MatrixAdjacency(int[,] matriz) => Matrix = matriz;

        public MatrixAdjacency(int ammountVertices)
        {
            Matrix = new int[ammountVertices, ammountVertices];
        }

        public void AddEdge(int vertice1, int vertice2)
        {
            Matrix[vertice1, vertice2]++;
            Matrix[vertice2, vertice1]++;
            EdgesAmmount++;
        }

        public void AddVertice()
        {
            Matrix = new int[this.VerticeCount() + 1, this.VerticeCount() + 1];
        }
    }
}
