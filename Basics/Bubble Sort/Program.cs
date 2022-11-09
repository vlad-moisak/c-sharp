using System;

public static class Program
{
	public static void Main()
	{
		int[] numbers = { 15, 9, 4, 21, 5, 40, 19 };

		ArraySort(numbers);
		ArrayPrint(numbers);
	}

	static void ArrayPrint(int[] a)
	{
		foreach (var x in a)
		{
			Console.Write($"[{x}] ");
		}
	}

	static void ArraySort(int[] a)
	{
		int l = a.Length;

		while (true)
		{
			bool swap = false;

			for (int i = 0; i < l - 1; i++)
			{
				if (a[i] <= a[i + 1]) continue;

				(a[i], a[i + 1]) = (a[i + 1], a[i]);

				swap = true;
			}

			if (swap == false)
			{
				break;
			}
		}
	}
}