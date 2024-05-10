using System.Text;

namespace AL_05_02
{
    public class GraphAdjList<T>
    {
        private readonly Dictionary<T, HashSet<T>> adjList = new Dictionary<T, HashSet<T>>();
        private readonly HashSet<(T, T)> edgesNonWeighted = new HashSet<(T, T)>();
        private readonly HashSet<(T, T, T)> edgesWeighted = new HashSet<(T, T, T)>();

        public string GraphType { get; set; }
        public bool ContainsVertex(T vertex) => adjList.ContainsKey(vertex);
        public bool ContainsEdge(T v1, T v2) => edgesNonWeighted.Contains((v1, v2)) || edgesNonWeighted.Contains((v2, v1));

        public GraphAdjList(string graphType) { GraphType = graphType; }

        public void AddVertex(T vertex)
        {
            if (!ContainsVertex(vertex))
                adjList.Add(vertex, new HashSet<T>());
        }

        public void AddEdge(T[] edge)
        {
            switch(GraphType)
            {
                case "g":
                case "d":
                    {
                        AddEdgeNonWeighted(edge[0], edge[1]);
                        break;
                    }
                case "gw":
                case "dw":
                    {
                        AddEdgeWeighted(edge[0], edge[1], edge[2]);
                        break;
                    }
            }
        }

        private void AddEdgeNonWeighted(T v1, T v2)
        {
            if (!ContainsVertex(v1) || !ContainsVertex(v2))
                throw new ArgumentException("Vertex not found in graph");
            if (ContainsEdge(v1, v2))
                return;
            adjList[v1].Add(v2);
            adjList[v2].Add(v1);
            edgesNonWeighted.Add((v1, v2));
        }

        private void AddEdgeWeighted(T v1, T v2, T weight)
        {
            if (!ContainsVertex(v1) || !ContainsVertex(v2))
                throw new ArgumentException("Vertex not found in graph");
            if (ContainsEdge(v1, v2))
                return;
            adjList[v1].Add(v2);
            adjList[v2].Add(v1);
            edgesWeighted.Add((v1, v2, weight));
        }

        public void AddEdgeAndVertices(params T[] edge)
        {
            AddVertex(edge[0]);
            AddVertex(edge[1]);
            AddEdge(edge);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            switch (GraphType)
            {
                case "g":
                    {
                        sb.AppendLine("graph {");
                        foreach (var (v1, v2) in edgesNonWeighted)
                        {
                            sb.AppendLine($"{v1} -- {v2};");
                        }
                        sb.AppendLine("}");
                        break;
                    }
                case "d":
                    {
                        sb.AppendLine("digraph {");
                        foreach (var (v1, v2) in edgesNonWeighted)
                        {
                            sb.AppendLine($"{v1} -> {v2};");
                        }
                        sb.AppendLine("}");
                        break;
                    }
                case "gw":
                    {
                        sb.AppendLine("graph {");
                        foreach (var (v1, v2, weight) in edgesWeighted)
                        {
                            sb.AppendLine($"{v1} -- {v2} [label = {weight}];");
                        }
                        sb.AppendLine("}");
                        break;
                    }
                case "dw":
                    {
                        sb.AppendLine("digraph {");
                        foreach (var (v1, v2, weight) in edgesWeighted)
                        {
                            sb.AppendLine($"{v1} -> {v2} [label = {weight}];");
                        }
                        sb.AppendLine("}");
                        break;
                    }
            }

            return sb.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int graphCount = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < graphCount; i++)
            {
                string graphType = Console.ReadLine();
                int verticesCount = int.Parse(Console.ReadLine());

                GraphAdjList<string> adjList = new GraphAdjList<string>(graphType);

                for(int j = 0; j < verticesCount; j++)
                {
                    string[] otw = Console.ReadLine().Split(" ");
                    adjList.AddEdgeAndVertices(otw);
                }

                sb.Append(adjList.ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
