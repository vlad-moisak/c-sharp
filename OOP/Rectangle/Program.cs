public static class Program
{
	public static void Main()
	{
		Rectangle r1 = new Rectangle(9, 5);

		Console.WriteLine($"Площадь = {r1.GetArea()}");
		Console.WriteLine($"Периметр = {r1.GetPerimeter()}");
	}
}