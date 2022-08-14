using System;
using System.Collections.Generic;

namespace ShokhovKP
{
    public class Clique
    {
        public List<int> Nodes { get; private set; }

        public Clique(List<int> nodes)
        {
            Nodes = nodes;
        }

        public void AddNode(List<int> nodes)
        {
            foreach(int node in nodes)
                if (Nodes.FindIndex(x => x == node) < 0)
                    Nodes.Add(node);
        }
        public void AddNode(int node)
        {
            if (Nodes.FindIndex(x => x == node) < 0)
                Nodes.Add(node);
        }

        public override bool Equals(object obj)
        {
            try
            {
                Clique sample = (Clique)obj;
                if (sample.Nodes.Count != Nodes.Count)
                    return false;

                for (int i = 0; i < Nodes.Count; i++)
                {
                    if (Nodes[i] != sample.Nodes[i])
                        return false;
                }
                return true;
            }
            catch
            {
                return base.Equals(obj);
            }
        }
        
        public override string ToString()
        {
            string result = "";
            foreach(int node in Nodes)
            {
                result += (node + 1) + " ";
            }
            result = result.Remove(result.Length - 1);
            return result;
        }
    }
}
