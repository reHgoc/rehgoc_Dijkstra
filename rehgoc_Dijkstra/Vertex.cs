using System;


namespace rehgoc_Dijkstra
{
    public class Vertex
    {
        public int index;
        public int distance;

        public Vertex(int _index, int _distance)
        {
            index = _index;
            distance = _distance;
        }

        public int CompareTo(Vertex other)
        {
            return distance.CompareTo(other.distance);
        }

        public override string ToString()
        {
            return String.Format($"{index}, {distance}");
        }
    }
}
