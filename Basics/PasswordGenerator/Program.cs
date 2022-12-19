using System;
using System.Linq;

public static class Program
{
	public static void Main()
	{
		int? count;

		string password = "";

		char[] rndPassword;

		string[] numbers =
		{
			"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
		};
		string[] word1 =
		{
			"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
			"O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
		};
		string[] word2 =
		{
			"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l",
			"m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
		};
		string[] symbols =
		{
			"@", "/", "!", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+",
			"=", "[", "]", "{", "}", ":", ";", "'", "`", "~", "|", ",", "<", ".",
			">", "?", "№"
		};

		Random rnd = new Random();

		do
		{
			Console.WriteLine("Пароль может быть от 8 до 36 символов!");
			Console.Write("Введите длину пароля: ");
			count = int.Parse(Console.ReadLine()!);
		} while (count < 8 || count > 36);

		do
		{
			for (int i = 0; i < count / 4; i++)
			{
				password = password + numbers[rnd.Next(0, 9)] + word1[rnd.Next(0, 26)]
									 + word2[rnd.Next(0, 26)] + symbols[rnd.Next(0, 31)];
			}

			String str = password;

			for (int i = 0; i < numbers.Length; i++)
			{
				int index1 = str.IndexOf(numbers[i], StringComparison.Ordinal);
				
				if (index1 != -1)
				{
					break;
				}
			}

			for (int i = 0; i < word1.Length; i++)
			{
				int index2 = str.IndexOf(word1[i], StringComparison.Ordinal);
				
				if (index2 != -1)
				{
					break;
				}
			}

			for (int i = 0; i < word2.Length; i++)
			{
				int index3 = str.IndexOf(word2[i], StringComparison.Ordinal);
				
				if (index3 != -1)
				{
					break;
				}
			}

			for (int i = 0; i < symbols.Length; i++)
			{
				int index4 = str.IndexOf(symbols[i], StringComparison.Ordinal);
				
				if (index4 != -1)
				{
					break;
				}
			}

		} while (false);

		rndPassword = password.ToCharArray();

		int KeySelector(char x) => rnd.Next();

		rndPassword = rndPassword.OrderBy(KeySelector).ToArray();
		Console.Write("\n Ваш пароль: ");
		Console.Write(string.Join("", rndPassword));
	}
}


