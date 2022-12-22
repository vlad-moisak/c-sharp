using System;

public static class Program
{
	public static void Main()
	{
		int passwordLength = GetPasswordLength();
		PasswordGenerator passwordGenerator = new PasswordGenerator();
		string password = passwordGenerator.GeneratePassword(passwordLength);
		Console.WriteLine($"Ваш пароль: {password}");
	}

	private static int GetPasswordLength()
	{
		int passwordLength;

		do
		{
			Console.WriteLine("Пароль должен быть от 8 до 32 символов.");
			Console.Write("Введите длину пароля: ");
			passwordLength = int.Parse(Console.ReadLine()!);
		} while (passwordLength is < 8 or > 32);

		return passwordLength;
	}
}