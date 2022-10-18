public static class Program
{
	public static void Main()
	{
		Console.Write("Как тебя зовут? ");
		string name = Console.ReadLine();
		Console.Write($"Привет, {name}!");
		
		Console.ReadLine();
	}
}