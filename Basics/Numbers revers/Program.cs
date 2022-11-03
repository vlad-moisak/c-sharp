public static class Program
{
	public static void Main()
	{
		// Узнаём количество чисел.

		Console.Write("Количество чисел: ");
		string countText = Console.ReadLine();
		int count = int.Parse(countText!);

		// Создаём массив на это количество чисел.

		int[] numbers = new int[count];

		// Заполняем массив числами, которые вводит пользователь.

		for (int i = 0; i < count; i++)
		{
			Console.Write($"Число #{i + 1}: ");
			var numberText = Console.ReadLine();
			numbers[i] = int.Parse(numberText!);
		}

		for (int i = numbers.Length - 1; i >= 0; i--)
		{
			Console.WriteLine(numbers[i]);
		}
		
		Console.ReadLine();
	}
}