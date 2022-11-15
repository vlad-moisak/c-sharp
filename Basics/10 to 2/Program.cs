using System;
using System.Collections.Generic;

public static class Program
{
	public static void Main()
	{
		while (true)
		{
			Console.Write(">>> ");
			string input = Console.ReadLine()!;

			if (input.ToLower() == "exit") break;

			bool success = long.TryParse(input, out long number);

			if (!success) continue;

			PrintBits(GetBits(number));
		}
	}

	private static List<bool>GetBits(long number)
	{
		List<bool> bits = new ();

		while (true)
		{
			bits.Insert(0, number % 2 > 0);

			number /= 2;

			if (number == 0) return bits;
		}
	}

	private static void PrintBits(List<bool> bits)
	{
		Console.Write("    ");

		bits.Reverse();

		for (int i = bits.Count - 1; i >= 0; i--)
		{
			Console.Write(bits[i] ? "1" : "0");

			if (i % 4 == 0)
			{
				Console.Write(" ");
			}
		}

		Console.WriteLine();
	}
}