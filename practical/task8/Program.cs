namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть речення:");
            string sentence = Console.ReadLine();

            string vowels = "aeiouAEIOU";

            int vowelCount = 0;

            foreach (char c in sentence)
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"Кількість голосних літер у реченні: {vowelCount}");
        }
    }
}
