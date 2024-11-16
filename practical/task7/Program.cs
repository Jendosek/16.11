namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть речення:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                char[] wordArray = words[i].ToCharArray();  
                Array.Reverse(wordArray);  
                words[i] = new string(wordArray);  
            }

            string reversedSentence = string.Join(" ", words);

            Console.WriteLine("Перевернуті слова:");
            Console.WriteLine(reversedSentence);
        }
    }
}
