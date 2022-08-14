using ShokhovKP.Exceptions;
using System;

namespace ShokhovKP
{
    /// <summary>
    /// клас для определения общей логики дочерних класов
    /// </summary>
    public class BaseRepresentation
    {
        /// <summary>
        /// Матрица которая хранит представление графа с разными весами ребер
        /// </summary>
        public int[,] Matrix { get; private set; }

        public BaseRepresentation() { }

        public BaseRepresentation(int[,] Matrix)
        {
            this.Matrix = Matrix;
        }

        public BaseRepresentation(int v, int e, bool symmetric)
        {
            Matrix = GenarateRandomMatrix(v, e, symmetric, 1, 1);
        }

        public BaseRepresentation(int v, int e, bool symmetric, int min, int max)
        {
            Matrix = GenarateRandomMatrix(v, e, symmetric, min, max);
        }
        
        public bool CheckMatrixSymmetric(int[,] Matrix)
        {
            if (Matrix.GetLength(0) == Matrix.GetLength(1))
                throw new NonSquareMmatrixRepresentation();
            int n = Matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Matrix[i, j] != Matrix[j, i])
                        return false;
                }
            }
            return true;
        }

        public int[,] GenarateRandomMatrix(int v, int e, bool symmetric, int min, int max)
        {
            //Проверки входных значений
            if (v <= 0)
                throw new NullVertexValueException();

            int maxE = (symmetric) ? ((v * v - v) / 2) : (v * v - v);
            if (e < 0 || e > maxE)
                throw new NumberOfEdgesOverMaximumException();
            //конец проверки входных значений

            int[,] matrix = new int[v, v];

            //Предварительное заполнение матрици
            for (int i = 0; i < v; i++)
                for (int j = 0; j < v; j++)
                    matrix[i, j] = 0;

            Random rnd = new Random();
            int counter = 0;

            while (counter < e)//Добавление количества ребер если их недостаточно
            {
                var i = rnd.Next(0, v);
                var j = rnd.Next(0, v);
                if (i != j)
                    if (matrix[i, j] == 0)
                    {
                        int weight = rnd.Next(min, max);
                        if (symmetric)
                        {
                            matrix[i, j] = weight;
                            matrix[j, i] = weight;
                            counter += 2;
                        }
                        else
                        {
                            matrix[i, j] = weight;
                            counter += 1;
                        }
                    }
            }
            return matrix;
        }

        public int CalculateEdges(int[,] matrix, bool symmetric = true)
        {
            int counter = 0;
            if (symmetric)
            {
                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                    for (int j = matrix.GetLength(1) - 1; j > i; j--)
                    {
                        if (matrix[i, j] != 0)
                            counter++;
                    }
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        if (matrix[i, j] != 0 && (i != j))
                            counter++;
            }
            return counter;
        }      
    }
}
