using System.Collections.Generic;

namespace ShokhovKP
{
    class BronKerbosch
    {
        private int[,] gmatrix;

        public BronKerbosch(int[,] matrix, bool isDirected)
        {
            if (isDirected)
            {
                gmatrix = matrix;
            }
            else
            {
                gmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        gmatrix[i, j] = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] != 0)
                        {
                            gmatrix[i, j] = matrix[i, j];
                            gmatrix[j, i] = matrix[i, j];
                        }
                    }
                }
            }
        }
        
        public List<Clique> FindAllCliques()
        {
            List<Clique> clique = new List<Clique>();

            //сюда помещаются вершины, образующие клику
            List<int> M = new List<int>();
            //список вершин графа
            List<int> K = new List<int>();
            //список "отработанных" вершин
            List<int> P = new List<int>();
            //вершина
            int v;
            Stack<int> stackV = new Stack<int>();
            Stack<List<int>> stackM = new Stack<List<int>>();
            Stack<List<int>> stackK = new Stack<List<int>>();
            Stack<List<int>> stackP = new Stack<List<int>>();
            //список несмежных с вершиной вершин
            List<int> GS = new List<int>();
            //заполняем список вершинами графа
            for (int i = 0; i < gmatrix.GetLength(0); i++)
                K.Add(i);
            while (K.Count != 0 || M.Count != 0)
            {
                if (K.Count != 0)
                {
                    v = K[0];
                    stackM.Push(M.GetRange(0, M.Count));
                    stackK.Push(K.GetRange(0, K.Count));
                    stackP.Push(P.GetRange(0, P.Count));
                    stackV.Push(v);
                    M.Add(v);
                    GS = G(v);
                    SubtractSet(K, GS);
                    SubtractSet(K, v);
                    SubtractSet(P, GS);
                }
                else
                {
                    if (P.Count == 0) //клика найдена
                        clique.Add(new Clique(M.GetRange(0, M.Count)));
                    M = stackM.Pop();
                    K = stackK.Pop();
                    P = stackP.Pop();
                    v = stackV.Pop();
                    SubtractSet(K, v);
                    P.Add(v);
                }
            }
            return clique;
        }
        /* вычитает вершину из множества */
        void SubtractSet(List<int> set, int vert)
        {
            for (int i = 0; i < set.Count; i++)
            {
                if (set[i] == vert)
                    set.RemoveAt(i);
            }
        }
        /* вычитает второе множество из первого */
        void SubtractSet(List<int> set1, List<int> set2)
        {
            for (int i = 0; i < set1.Count; i++)
                for (int j = 0; j < set2.Count; j++)
                    if (set1.Count != 0 && i < set1.Count)
                        if (set1[i] == set2[j])
                            set1.RemoveAt(i);
        }
        /* возвращает список вершин, не смежных с vert */
        List<int> G(int vert)
        {
            List<int> ret = new List<int>();
            for(int i = 0; i < gmatrix.GetLength(0); i++)// (int i = 0; i < gmatrix.Dimension; i++)
                if (gmatrix[i, vert] == 0)//(gmatrix.Get(i, vert) == 0)
                    ret.Add(i);
            return ret;
        }
    }
}
