namespace CloneGraph
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }

        public Node CloneGraph(Node node)
        {
            if (node == null)
            {
                return null;
            }
            Dictionary<Node, Node> m = new Dictionary<Node, Node>();
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(node);
            Node cloneNode = new Node();
            cloneNode.val = node.val;
            m[node] = cloneNode;

            while (q.Count > 0)
            {
                Node u = q.Dequeue();
                List<Node> v = u.neighbors.ToList();
                foreach (Node neighbor in v)
                {
                    if (!m.ContainsKey(neighbor))
                    {
                        cloneNode = new Node();
                        cloneNode.val = neighbor.val;
                        m[neighbor] = cloneNode;
                        q.Enqueue(neighbor);
                    }
                    m[u].neighbors.Add(m[neighbor]);
                }
            }

            return m[node];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(1);
            Node clone = node.CloneGraph(node);
        }
    }
}
