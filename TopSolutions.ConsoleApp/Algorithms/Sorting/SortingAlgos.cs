using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Algorithms.Sorting
{
    public class SortingAlgos
    {
        public void Bubble(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
           
        }
        public void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }            
        }
        public void QuickSort(int[] arr, int left, int right)
        {           
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }           
        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp2;
            return i + 1;
        }
        //Djikstra's algorithm is not a sorting algorithm, but rather a graph traversal algorithm used to find the shortest path between nodes in a graph.
        //However, if you want to implement Dijkstra's algorithm in C#, here's a simple implementation:
        public void Dijkstra(int[,] graph, int source)
        {
            int n = graph.GetLength(0);
            int[] dist = new int[n];
            bool[] visited = new bool[n];
            for (int i = 0; i < n; i++)
            {
                dist[i] = int.MaxValue;
                visited[i] = false;
            }
            dist[source] = 0;
            for (int count = 0; count < n - 1; count++)
            {
                int u = MinDistance(dist, visited);
                visited[u] = true;
                for (int v = 0; v < n; v++)
                {
                    if (!visited[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                    }
                }
            }
            PrintSolution(dist);
        }
        public void PrintSolution(int[] dist)
        {
            Console.WriteLine("Vertex Distance from Source");
            for (int i = 0; i < dist.Length; i++)
            {
                Console.WriteLine($"{i}\t\t{dist[i]}");
            }

        }
        private int MinDistance(int[] dist, bool[] visited)
        {
            int min = int.MaxValue;
            int minIndex = -1;
            for (int v = 0; v < dist.Length; v++)
            {
                if (!visited[v] && dist[v] <= min)
                {
                    min = dist[v];
                    minIndex = v;
                }
            }
            return minIndex;
        }
    }
}
