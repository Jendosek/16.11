namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть речення:");
            string sentence = Console.ReadLine();

            sentence = sentence.Trim();

            if (string.IsNullOrEmpty(sentence))
            {
                Console.WriteLine("У реченні немає слів.");
                return;
            }

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;

            Console.WriteLine($"Кількість слів у реченні: {wordCount}");
        }
    }
}
