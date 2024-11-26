public static class FloydMethod
{
	public static void FloydAlgorithm(int[,] graph, int verticesCount)
	{
		int[,] dist = new int[verticesCount, verticesCount];
		int[,] nodes = new int[verticesCount, verticesCount];
		for (int i = 0; i < verticesCount; i++)
		{
			for (int j = 0; j < verticesCount; j++)
			{
				if (i == j)
				{
					dist[i, j] = 0;
				}
				else if (graph[i, j] != 0)
				{
					dist[i, j] = graph[i, j];
				}
				else
				{
					dist[i, j] = int.MaxValue;
				}
			}
		}
		for (int k = 0; k < verticesCount; k++)
		{
			for (int i = 0; i < verticesCount; i++)
			{
				for (int j = 0; j < verticesCount; j++)
				{
					int newVal = dist[i, k] + dist[k, j];
					if (dist[i, k] != int.MaxValue && dist[k, j] != int.MaxValue
					&&
					 (dist[i, j] == int.MaxValue || dist[i, j] > newVal))
					{
						dist[i, j] = newVal;
						nodes[i, j] = k + 1;
					}
				}
			}
			Console.WriteLine("======");
			PrintResult(dist, nodes, verticesCount);
			Console.WriteLine("======");

		}
		PrintResult(dist, nodes, verticesCount);
	}
	static void PrintResult(int[,] dist, int[,] nodes, int verticesCount)
	{
		Console.WriteLine("Distance matrix:");
		for (int i = 0; i < verticesCount; i++)
		{
			for (int j = 0; j < verticesCount; j++)
			{
				if (dist[i, j] == int.MaxValue)
				{
					Console.Write("-\t");
				}
				else
				{
					Console.Write($"{dist[i, j]}\t");
				}
			}
			Console.WriteLine();
		}
		Console.WriteLine();
		for (int i = 0; i < verticesCount; i++)
		{
			for (int j = 0; j < verticesCount; j++)
			{
				Console.Write(nodes[i, j] + "\t");
			}
			Console.WriteLine();
		}
	}
}