namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(DateTime.Now.Millisecond);

            Console.WriteLine("Enter the lower bound of the random number: ");
            var lowerMaxRandomBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper bound of the random number: ");
            var upperMaxRandomBound = Convert.ToInt32(Console.ReadLine());

            if (lowerMaxRandomBound > upperMaxRandomBound)
            {
                (lowerMaxRandomBound, upperMaxRandomBound) = (upperMaxRandomBound, lowerMaxRandomBound);
            }

            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(lowerMaxRandomBound, upperMaxRandomBound + 1);
            }

            Console.WriteLine("The generated array is: ");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine("Enter the threshold value: ");
            int threshold = Convert.ToInt32(Console.ReadLine());

            int countLessThanThreshold = 0;
            foreach (int number in arr)
            {
                if (number < threshold)
                {
                    countLessThanThreshold++;
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Count {threshold}: {countLessThanThreshold}");
        }
    }
}
