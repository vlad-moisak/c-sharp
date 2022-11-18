using System;
using System.Collections.Generic;

public static class Program
{
	public static void Main()
	{
		string text = "asdfga";

		Dictionary<char, int> lettersCount = new Dictionary<char, int>();

		for (int i = 0; i < text.Length; i++)	
		{
			char c = text[i];

			if (!lettersCount.ContainsKey(c))
			{
				lettersCount.Add(c, 1);
			}
			else
			{
				lettersCount[c]++;
			}
		}

		foreach (KeyValuePair<char, int> kvp in lettersCount)
		{
			Console.WriteLine("Key = {0}, Value ={1}", kvp.Key, kvp.Value);
		}

		Console.ReadLine();
	}
}