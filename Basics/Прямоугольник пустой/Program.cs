public static class Program
{
	public static void Main()
	{
		Console.Write("Задайте ширину прямоугольника: ");
		var a = int.Parse(Console.ReadLine()!);

		Console.Write("Задайте высоту прямоугольника: ");
		var b = int.Parse(Console.ReadLine()!);

		for (var height = 1; height <= b; height++)
		{
			for (var width = 1; width <= a; width++)
			{
				if (width > 1 && width < a && height > 1 && height < b)
				{
					Console.Write(" ");
				}
				else
				{
					Console.Write("*");
				}
			}

			Console.WriteLine();
		}

		Console.ReadLine();
	}
}