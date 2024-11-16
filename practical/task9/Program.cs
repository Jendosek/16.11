namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть рядок:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Введіть підрядок для пошуку:");
            string searchWord = Console.ReadLine();

            if (string.IsNullOrEmpty(searchWord))
            {
                Console.WriteLine("Підрядок не був введений.");
                return;
            }

            int count = 0;
            int index = 0;

            while ((index = inputString.IndexOf(searchWord, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += searchWord.Length;
            }

            Console.WriteLine($"Кількість входжень підрядка \"{searchWord}\": {count}");
        }
    }
}
