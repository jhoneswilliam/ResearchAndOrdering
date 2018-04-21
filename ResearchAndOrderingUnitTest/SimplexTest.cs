using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResearchAndOrdering.Graph;
using ResearchAndOrderingUnitTest.Utils;

namespace ResearchAndOrderingUnitTest
{
    [TestClass]
    public class SimplexTest
    {
        [TestMethod]
        public void TestGraphRandom()
        {
            LinkedList<int> routerExpected = new LinkedList<int>();
            routerExpected.AddLast(0);
            routerExpected.AddLast(1);
            routerExpected.AddLast(3);
            routerExpected.AddLast(4);

            MatrixAdjacency matrixIncidence = new MatrixAdjacency(5);
            int verticeStart = 0;
            int verticeEnd = 4;

            matrixIncidence.AddEdge(0, 2);
            matrixIncidence.AddEdge(0, 1);
            matrixIncidence.AddEdge(1, 3);
            matrixIncidence.AddEdge(3, 4);

            LinkedList<int> routerAtual = new Simplex(matrixIncidence).run(verticeStart, verticeEnd);

            string routerExpectedString = ConvertCollection<int>.ToString(routerExpected);
            string routerAtualString = ConvertCollection<int>.ToString(routerAtual);

            Assert.AreEqual(routerExpectedString, routerAtualString, null, "The routers no are equals");            
        }
    }
}
