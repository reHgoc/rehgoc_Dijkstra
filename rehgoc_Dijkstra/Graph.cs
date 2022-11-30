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

        public void AddOrientedEdge(int _edgeIndex, int _to, int _weight)
        {
            //add 
            _link[_edgeIndex].Add(new Edge(_to, _weight));
        }

        public void AddUnorientedEdge(int _edgeIndex, int _to, int _weight)
        {
            AddOrientedEdge(_edgeIndex, _to, _weight);
            AddOrientedEdge(_to, _edgeIndex, _weight);

        }

        public List<Edge> FromVertex(int _edgeIndex)
        {
            return _link[_edgeIndex];
        }
    }
}
