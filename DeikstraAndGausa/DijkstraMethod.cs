public static class DijkstraMethod
{
	public static void DijkstraAlgorithm(int[,] graph, int source, int
   verticesCount)
	{
		int[] dist = new int[verticesCount];
		bool[] shortestPathTree = new bool[verticesCount];
		int[] prev = new int[verticesCount];
		for (int i = 0; i < verticesCount; i++)
		{
			dist[i] = int.MaxValue;
			shortestPathTree[i] = false;
			prev[i] = -1;
		}
		dist[source] = 0;
		for (int count = 0; count < verticesCount - 1; count++)
		{
			int u = MinDistance(dist, shortestPathTree, verticesCount);
			shortestPathTree[u] = true;
			for (int v = 0; v < verticesCount; v++)
			{
				if (!shortestPathTree[v] && graph[u, v] != 0 && dist[u] !=
			   int.MaxValue &&
				dist[u] + graph[u, v] < dist[v])
				{
					dist[v] = dist[u] + graph[u, v];
					prev[v] = u;
				}
			}
		}
		PrintResult(dist, prev, verticesCount, source);
	}

	private static int MinDistance(int[] dist, bool[] shortestPathTree, int
   verticesCount)
	{
		int min = int.MaxValue;
		int minIndex = -1;
		for (int v = 0; v < verticesCount; v++)
		{
			if (!shortestPathTree[v] && dist[v] <= min)
			{
				min = dist[v];
				minIndex = v;
			}
		}
		return minIndex;
	}
	private static string GetPath(int[] prev, int vertex)
	{
		if (vertex == -1)
			return "";
		List<int> path = new List<int>();
		while (vertex != -1)
		{
			path.Insert(0, vertex + 1);
			vertex = prev[vertex];
		}
		return string.Join(" -> ", path);
	}
	private static void PrintResult(int[] dist, int[] prev, int verticesCount,
   int source)
	{
		Console.WriteLine("Vertex\t Distance\t Path");
		for (int i = 0; i < verticesCount; i++)
		{
			string path = GetPath(prev, i);
			Console.WriteLine($"{i + 1}\t {dist[i]}\t\t {path}");
		}
	}
}