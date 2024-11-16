namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть три числа, розділених пробілом:");
            string[] numbers = Console.ReadLine().Split(' ');

            if (numbers.Length != 3 ||
                !int.TryParse(numbers[0], out int num1) ||
                !int.TryParse(numbers[1], out int num2) ||
                !int.TryParse(numbers[2], out int num3))
            {
                Console.WriteLine("Помилка: введіть рівно три цілі числа.");
                return;
            }

            int[] array = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };

            int count = 0;
            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i] == num1 && array[i + 1] == num2 && array[i + 2] == num3)
                {
                    count++;
                }
            }

            Console.WriteLine($"Кількість повторень послідовності: {count--}");
        }
    }
}
