namespace PT07Z
{
    public class Graph
    {
        #region Graph props, constructor and Add Edge method
        public int VerticesCount;

        // adjList with weight
        private List<int>[] adjList;

        public Graph(int vertices)
        {
            VerticesCount = vertices;
            adjList = new List<int>[VerticesCount + 1];

            for (int i = 1; i <= VerticesCount; i++)
            {
                adjList[i] = new List<int>();
            }
        }

        public void AddEdge(int origin, int destination)
        {
            adjList[origin].Add(destination);
            adjList[destination].Add(origin);
        }
        #endregion

        #region Find Longest Path
        public Tuple<int, int> FindLongestPath(int start)
        {
            bool[] visited = new bool[VerticesCount + 1];
            Queue<int> queue = new Queue<int>();
            visited[start] = true;
            queue.Enqueue(start);

            int furthestVertex = 0;
            int furthestDistance = -1;

            while (queue.Count > 0)
            {
                furthestVertex = queue.Peek();
                ++furthestDistance;

                int waveSize = queue.Count;
                for (int i = 0; i < waveSize; ++i)
                {
                    var vertex = queue.Dequeue();

                    foreach (var neighbor in adjList[vertex])
                    {
                        if (!visited[neighbor])
                        {
                            visited[neighbor] = true;
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }

            return Tuple.Create(furthestVertex, furthestDistance);
        }
        #endregion
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int verticesCount = int.Parse(Console.ReadLine());

            if (verticesCount == 1)
            {
                Console.WriteLine(0);
                return;
            }

            Graph graph = new Graph(verticesCount);

            for (int i = 0; i < verticesCount - 1; i++)
            {
                int[] ot = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                graph.AddEdge(ot[0], ot[1]);
            }

            Tuple<int, int> second = graph.FindLongestPath(1);
            int longestPath = graph.FindLongestPath(second.Item1).Item2;

            Console.WriteLine(longestPath);
        }
    }
}
