using System.Collections.Generic;

namespace ShokhovKP
{
    public class GFG
    {
        private int[] store;
        private int n;

        private int[,] graph;
        private List<Clique> cliques = new List<Clique>();
        private int[] d;

        public GFG(int[,] Matrix, bool isDirected)
        {
            int CountNode = Matrix.GetLength(0);
            graph = new int[CountNode + 1, CountNode + 1];
            d = new int[CountNode + 1];
            store = new int[CountNode + 1];
            n = CountNode;
            //перенос матрици смежности в рабочую матрицу
            if (isDirected)
            {
                for (int i = 0; i < CountNode; i++)
                {
                    for (int j = 0; j < CountNode; j++)
                    {
                        graph[i + 1, j + 1] = Matrix[i, j];
                        if (Matrix[i, j] != 0)
                        {
                            d[i + 1]++;
                            d[j + 1]++;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < CountNode; i++)
                {
                    for (int j = 0; j < CountNode; j++)
                    {
                        graph[i + 1, j + 1] = Matrix[i, j];
                        graph[j + 1, i + 1] = Matrix[j, i];
                        if (Matrix[i, j] != 0)
                        {
                            graph[i + 1, j + 1] = 1;
                            graph[j + 1, i + 1] = 1;

                            d[i + 1]++;
                            d[j + 1]++;
                        }
                    }
                }
            }
        }

        public List<Clique> FoundClique()
        {
            for (int k = 1; k <= n; k++)
            {
                for (int i = 0; i <= n; i++)
                    store[i] = 0;
                findCliques(0, 1, k);
            }
            return cliques;
        }

        private bool is_clique(int b)
        {
            for (int i = 1; i < b; i++)
            {
                for (int j = i + 1; j < b; j++)
                    if (graph[store[i], store[j]] == 0)
                        return false;
            }
            return true;
        }

        private void SaveClique(int n)
        {
            List<int> nodes = new List<int>();
            for (int i = 1; i < n; i++)
                nodes.Add(store[i] - 1);
            cliques.Add(new Clique(nodes));
        }
        
        private void findCliques(int i, int l, int s)
        {
            for (int j = i + 1; j <= n - (s - l); j++)
                if (d[j] >= s - 1)
                {
                    store[l] = j;
                    if (is_clique(l + 1))
                        if (l < s)
                            findCliques(j, l + 1, s);
                        else
                            SaveClique(l + 1);
                }
        }
    }
}
