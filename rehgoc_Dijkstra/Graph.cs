using System;


namespace rehgoc_Dijkstra
{
    public class Graph
    {

        private List<List<Edge>> _link;
        public int VertexCount { get { return _link.Count; } }

        public Graph(int _vertexCount)
        {
            _link = new List<List<Edge>>(_vertexCount);

            for (int i = 0; i < _vertexCount; i++)
            {
                _link.Add(new List<Edge>());
            }
        }

        public void AddOrientedEdge(int u, int v, int w)
        {
            //add 
            _link[u].Add(new Edge(v, w));
        }

        public void AddUnorientedEdge(int u, int v, int w)
        {
            AddOrientedEdge(u, v, w);
            AddOrientedEdge(v, u, w);

        }

        public List<Edge> FromVertex(int u)
        {
            return _link[u];
        }
    }
}
