public abstract class Program
{
	public static void Main()
	{
		int[,] graph =
		{
		 { 0, 4, 3, 1, 0, 0, 0, 0, 0, 0 },
		 { 4, 0, 0, 0, 6, 3, 13, 0, 0, 0 },
		 { 3, 0, 0, 0, 4, 7, 0, 0, 0, 0 },
		 { 1, 0, 0, 0, 5, 6, 0, 0, 0, 0 },
		 { 0, 6, 4, 5, 0, 0, 11, 4, 3, 0 },
		 { 0, 3, 7, 6, 0, 0, 9, 6, 8, 0 },
		 { 0, 13, 0, 0, 11, 9, 0, 3, 0, 6 },
		 { 0, 0, 3, 0, 4, 6, 3, 0, 2, 4 },
		 { 0, 0, 0, 0, 3, 8, 0, 2, 0, 5 },
		 { 0, 0, 0, 0, 0, 0, 6, 4, 5, 0 }
		};
		int source = 0;
		DijkstraMethod.DijkstraAlgorithm(graph, source, graph.GetLength(0));
		FloydMethod.FloydAlgorithm(graph, graph.GetLength(0));
	}
}