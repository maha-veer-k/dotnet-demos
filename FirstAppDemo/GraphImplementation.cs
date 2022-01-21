using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppDemo
{

    public class Build
    {
        List<int>[] Graph;
       
        public Build(int n)
        {
            Graph = new List<int>[n+1];
        }

        internal void BuildGraph(int edge)
        {
            //throw new NotImplementedException();
            for(int i = 0; i < edge; i++)
            {
                int v = Convert.ToInt32(Console.ReadLine());
                int u = Convert.ToInt32(Console.ReadLine());
                if(Graph[v] == null)
                {
                    Graph[v] = new List<int>();
                    Graph[v].Add(u);
                }
                else
                {
                    Graph[v].Add(u);  
                }
            }
        }

        internal void DisplayGraph()
        {
            for(int i = 1; i < Graph.Length; i++)
            {
                Console.WriteLine(i + " ->  ");
                if (Graph[i] == null) continue;
                for(int j = 0; j < Graph[i].Count; j++)
                {
                    Console.WriteLine(Graph[i][j] + " , ");
                }
            }
        }
    }
    public class GraphImplementation
    {
        static void main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Build graph = new Build(n);
            int edge = Convert.ToInt32(Console.ReadLine());
            graph.BuildGraph(edge);
            graph.DisplayGraph();

        }
    }
}
