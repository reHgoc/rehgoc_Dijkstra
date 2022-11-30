using System;

namespace rehgoc_Dijkstra
{
    public class Algorithm
    {
        public static void Dijkstra(Graph graph, int startVertex, out int[] distance, out int[] parent)
        {
            distance = new int[graph.VertexCount];
            parent = new int[graph.VertexCount];
            bool[] isVisited = new bool[graph.VertexCount];

            //Init
            for (int i = 0; i < graph.VertexCount; i++)
            {
                distance[i] = int.MaxValue;
                parent[i] = -1;
                isVisited[i] = false;

            }

            //Start (in first point - start vertex)
            PriorityQueue<Vertex, int> _priorityQueu = new PriorityQueue<Vertex, int>();
            distance[startVertex] = 0;

            _priorityQueu.Enqueue(new Vertex(startVertex, 0), 0);

            while (_priorityQueu.Count > 0)
            {
                Vertex current = _priorityQueu.Dequeue();
                if (isVisited[current.index])
                {
                    continue;
                }
                isVisited[current.index] = true;

                foreach (Edge edge in graph.FromVertex(current.index))
                {
                    if (!isVisited[edge.to] && distance[current.index] + edge.weight < distance[edge.to])
                    {
                        parent[edge.to] = current.index;
                        distance[edge.to] = distance[current.index] + edge.weight;
                        _priorityQueu.Enqueue(new Vertex(edge.to, distance[edge.to]), distance[edge.to]);
                    }
                }
            }
        }
    }
}
