using ShokhovKP.Exceptions;
using System;

namespace ShokhovKP
{
    public class FO: BaseRepresentation
    {
        public int[] fo { get; set; }
        public FO() { }

        public FO(int[] FO) : base(CreateMatrix(FO)) { fo = FO; }

        public FO(int[,] Matrix) : base(Matrix) { }

        public FO(int v, int e, bool symmetric) : base(v, e, symmetric) { }

        public FO(int v, int e, bool symmetric, int min, int max) : base(v, e, symmetric, min, max) { }

        public static int[,] CreateMatrix(int[] FO)
        {
            FO fo = new FO();
            int n = fo.CalculateNodes(FO);
            int[,] matrix = new int[n, n];
            int vertices = 0;

            for (int i = 0; i < FO.Length; i++)
                if (FO[i] != 0)
                    matrix[vertices, FO[i] - 1] = 1;
                else
                    vertices++;
            return matrix;
        }

        public int[] CreateFO(int[,] Matrix)
        {
            int n = Matrix.GetLength(0);
            int edge = CalculateEdges(Matrix, false);
            int[] FO = new int[edge + n];
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (Matrix[i, j] != 0)
                    {
                        FO[counter] = j + 1;
                        counter++;
                    }
                FO[counter] = 0;
                counter++;
            }
            return FO;
        }
        
        public bool CheckRepresentation(int[] FO)
        {
            try
            {
                if (FO == null)
                    throw new ArgumentNullException();
                if (FO[0] <= 0)
                    throw new NullVertexValueException();
                int n = CalculateNodes(FO);
                for (int i = 0; i < FO.Length; i++)
                {
                    if (i > 0 && FO[i] > n)
                        throw new Exception("Номер вершины не может быть больше, чем " +
                            "количество вершин");
                    if (FO[i] < 0)
                        throw new NegativeVertexValueException();
                }
                int[,] matrix = CreateMatrix(FO);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public int CalculateNodes(int[] FO)
        {
            int counter = 0;
            for (int i = 0; i < FO.Length; i++)
                if (FO[i] == 0)
                    counter++;
            return counter;
        }
    }
}
