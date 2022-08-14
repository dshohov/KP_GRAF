using System;
using System.Collections.Generic;
using System.Linq;

namespace ShokhovKP
{
    public class CompareGraphs
    {
        public static List<Clique> Clique1;
        public static FO FO1;

        public static List<Clique> Clique2;
        public static FO FO2;

        private string summary;

        public bool Compare()
        {
            bool checkCountOfVector = true;
            string checkVector = "";

            summary = "\t\tПорівняння графів\n";
            summary += "\tПерший: " + String.Join(" ", FO1.fo) + "\n";
            summary += "\tДругий: " + String.Join(" ", FO2.fo) + "\n";

            //Формирование векторов
            List<Vector> VectorOfFirstGraph = CreateVector(Clique1, FO1.Matrix.GetLength(0));
            List<Vector> VectorOfSecondGraph = CreateVector(Clique2, FO2.Matrix.GetLength(0));

            //Проверка векторов и их отображение
            int maxCountVector = (VectorOfFirstGraph.Count > VectorOfSecondGraph.Count) ?
                    VectorOfFirstGraph.Count : VectorOfSecondGraph.Count;
            for (int i = 0; i < maxCountVector; i++)
            {
                summary += "\n\n\tВектор " + (i + 1) + "\n";

                //проверка одинаковости векторов
                bool isEqual = true;
                if (VectorOfFirstGraph.Count == maxCountVector && VectorOfSecondGraph.Count == maxCountVector)
                {
                    if (VectorOfFirstGraph[i].values.Count == VectorOfSecondGraph[i].values.Count)
                    {
                        for (int j = 0; j < VectorOfFirstGraph[i].values.Count; j++)
                        {
                            if (!CompareVectors(VectorOfFirstGraph[i].values[j], VectorOfSecondGraph[i].values[j]))
                            {
                                checkVector += (i + 1) + " ";
                                isEqual = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        checkVector += (i + 1) + " ";
                        isEqual = false;
                    }
                }
                else
                {
                    checkCountOfVector = false;
                    isEqual = false;
                }
                //Отрисовка соответствующих векторов графов
                string G1 = "Першого графу: ", G2 = "Другого графу: ";
                if (VectorOfFirstGraph.Count > i)
                {
                    for (int j = 0; j < VectorOfFirstGraph[i].values.Count; j++)
                        G1 += "P(" + VectorOfFirstGraph[i].values[j].Power + ") = " +
                            VectorOfFirstGraph[i].values[j].Count + ", ";
                    G1 = G1.Remove(G1.Length - 2);
                }

                if (VectorOfSecondGraph.Count > i)
                {
                    for (int j = 0; j < VectorOfSecondGraph[i].values.Count; j++)
                        G2 += "P(" + VectorOfSecondGraph[i].values[j].Power + ") = " +
                            VectorOfSecondGraph[i].values[j].Count + ", ";
                    G2 = G2.Remove(G2.Length - 2);
                }
                //промежуточный вывод
                summary += G1 + "\n" + G2 + "\n\t" + ((isEqual) ? "Вектори співпадають" : "Вектори не співпадають");
            }

            bool equivalent = true;

            //Подвидение вывода
            if (!checkCountOfVector || checkVector.Length > 0)
            {
                equivalent = false;
                summary += "\n\nГрафи не єквівалентні за:";
                if (!checkCountOfVector)
                {
                    summary += "\n\t* Кількістю векторів";
                }
                if (checkVector.Length > 0)
                {
                    summary += "\n\t* Векторами: " + checkVector;
                }
            }
            return equivalent;
        }

        private bool CompareVectors(Vector.PowerAndCount powerAndCount1, Vector.PowerAndCount powerAndCount2) =>
            powerAndCount1.Count == powerAndCount2.Count;

        private List<Vector> CreateVector(List<Clique> Clique, int CountNodes)
        {
            List<Vector> vectors = new List<Vector>();
            int maxClique = MaxPowerClique(Clique);
            for (int i = 0; i < CountNodes; i++)//проход по вершинам графа тем самым формируем вектора
            {
                Vector vector = new Vector();
                for (int j = 2; j <= maxClique; j++)
                {
                    int count = Clique.Where(cl => cl.Nodes.Any(node => node == i))//нахождение всех клик с цифрой вершины
                                      .Where(c2 => c2.Nodes.Count == j).Count();//из них уже отсеевание тех у которых мощность не соответствует
                    vector.values.Add(new Vector.PowerAndCount(j, count));
                }
                vectors.Add(vector);
            }
            return vectors;
        }

        private int MaxPowerClique(List<Clique> cliques) => cliques.Max(x => x.Nodes.Count);

        public override string ToString() => summary;

        private class Vector
        {
            public List<PowerAndCount> values;
            public Vector()
            {
                values = new List<PowerAndCount>();
            }

            public class PowerAndCount
            {
                public int Power { get; set; }
                public int Count { get; set; }
                public PowerAndCount(int Power, int Count)
                {
                    this.Power = Power;
                    this.Count = Count;
                }
            }
        }
    }
}
