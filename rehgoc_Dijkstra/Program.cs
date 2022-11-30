using rehgoc_Dijkstra;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Create and fill matrix

        Console.WriteLine("Enter count vertex and count edges.\nFor example: 4 4");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int _countVertex = arr[0], _countEdges = arr[1]; 

        Console.WriteLine("Enter start and end points.\nFor example: 1 4");
        int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int _startVertex = arr2[0], _endVertex = arr2[1];
        _startVertex--; _endVertex--;

        Graph graph = new Graph(_countVertex);

        

        for (int i = 0; i < _countEdges; i++)
        {
            Console.WriteLine("Enter 2 connected points and length of path between.\nFor example: 1 2 5");
            int[] arrEdge = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            arrEdge[0]--; arrEdge[1]--;

            graph.AddUnorientedEdge(arrEdge[0], arrEdge[1], arrEdge[2]);
        }

        int[] _distance;
        int[] _parent;

        Algorithm.Dijkstra(graph, _startVertex, out _distance, out _parent);

        /*
                //Debug 
                for (int i = 0; i < _countVertex; i++)
                {
                    Console.WriteLine($"{i + 1}, {distance[i]}, {parent[i] + 1}");
                }
        */
        if (_distance[_endVertex] == int.MaxValue)
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine(_distance[_endVertex]);
            List<int> path = new List<int>();
            int curent = _endVertex;
            while (curent != _startVertex)
            {
                path.Add(curent);
                curent = _parent[curent];
            }
            path.Add(_startVertex);
            for (int i = path.Count - 1; i >= 0; i--)
            {
                Console.Write($"{path[i] + 1} ");
            }
        }

        //--------------------------------------------------------------------



        Console.ReadLine();
    }




}
