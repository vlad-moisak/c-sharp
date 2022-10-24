public static class Program
{
    public static void Main()
    {
        Console.Write("Задайте ширину прямоугольника: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Задайте высоту прямоугольника: ");
        int b = int.Parse(Console.ReadLine());

        for (int height = 1; height <= b; height++)
        {
            for (int width = 1; width <= a; width++)
            {
                if (width > 1 && width < a && height > 1 && height < b)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}