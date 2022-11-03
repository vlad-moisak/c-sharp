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

		// Выводим минимальное число.

		int minValue = numbers[0];

		for (int i = 1; i < numbers.Length; i++)
		{
			if (numbers[i] < minValue)
				{
					minValue = numbers[i];
				}
		}

		Console.WriteLine($"min = " + minValue);

		// Выводим максимальное число.

		int maxValue = numbers[0];

		for (int i = 1; i < numbers.Length; i++)
			{
			if (numbers[i] > maxValue)
				{
				maxValue = numbers[i];
				}
			}

		Console.WriteLine($"max = " + maxValue);

		// Выводим сумму чисел.

		int sum = 0;

		for (int i = 0; i < numbers.Length; i++)
		{
			sum = sum + numbers[i];
		}

		Console.WriteLine($"sum = " + sum);

		Console.ReadLine();
	}
}