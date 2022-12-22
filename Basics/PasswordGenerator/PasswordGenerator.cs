using System;
using System.Collections.Generic;

public class PasswordGenerator
{
	private static readonly char[] LowerCaseLetters =
	{
		'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
		'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
	};

	private static readonly char[] Numbers =
	{
		'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
	};

	private static readonly char[] Symbols =
	{
		'@', '/', '!', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+',
		'=', '[', ']', '{', '}', ':', ';', '\'', '`', '~', '|', ',', '<', '.',
		'>', '?', '№'
	};

	private static readonly char[] UpperCaseLetters =
	{
		'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
		'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
	};

	public string GeneratePassword(int passwordLength)
	{
		char[] characters = new char[passwordLength];
		Random random = new Random();

		for (int i = 0; i < passwordLength; i++)
		{
			char[] array = GetArray(i);
			int randomIndex = random.Next(0, array.Length - 1);
			characters[i] = array[randomIndex];
		}

		string password = string.Empty;
		List<int> selectedIndexes = new List<int>();

		while (true)
		{
			int index = random.Next(0, passwordLength);
			if (selectedIndexes.Contains(index)) continue;
			selectedIndexes.Add(index);
			password += characters[index];
			if (password.Length == passwordLength) break;
		}

		return password;
	}

	private static char[] GetArray(int index)
	{
		if (index % 4 == 0) return Numbers;
		if (index % 4 == 1) return UpperCaseLetters;
		if (index % 4 == 2) return LowerCaseLetters;
		return Symbols;
	}
}