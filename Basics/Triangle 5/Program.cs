public static class Program
{
	public static void Main()
	{
		Console.Write("Задайте высоту треугольника: ");
		int height = int.Parse(Console.ReadLine());

		int a = 0;

		for (int i = height; i > 0; i--)
		{
			for (int j = 0; j < i; j++)
			{
				Console.Write(" ");
			}
			for (int f = 0; f <= a * 2; f++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
			a++;
		}
	}
}