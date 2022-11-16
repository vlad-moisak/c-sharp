using System;

public static class Program
{
	public static void Main()
	{
    Console.WriteLine("Введите текст:");

    var text = Console.ReadLine();
    var textMass = text?.Split(' ');

    Console.WriteLine("Количество слов:" + textMass!.Length);

    foreach (var t in textMass)
    {
      Console.WriteLine(t);
    }

    Console.ReadLine();
  }
}