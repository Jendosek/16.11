namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
            { 5, 12, 8 },
            { 3, 7, 14 },
            { 6, 2, 9 }
        };

            int min = array[0, 0];
            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }

            Console.WriteLine($"Мінімальне значення у масиві: {min}");
            Console.WriteLine($"Максимальне значення у масиві: {max}");
        }
    }
}
