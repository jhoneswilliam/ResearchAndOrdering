using ResearchAndOrdering.Graph;

namespace ResearchAndOrdering.Teste
{
    class GraphTeste
    {
        public static string Simple()
        {
            MatrixIncidence matrixIncidence = new MatrixIncidence(5, 3);
            matrixIncidence.AddEdge(0, 1);
            matrixIncidence.AddEdge(1, 2);
            matrixIncidence.AddEdge(2, 3);
            matrixIncidence.ToConsole();
            //Graph<MatrixIncidence> graph = new Graph<MatrixIncidence>(matrixIncidence);
           //return new Simple<MatrixIncidence>(graph).run();
            return "";
        }



        //Simple simples = new Simple();
    }
}
