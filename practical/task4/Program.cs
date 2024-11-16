namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            int[] array2 = { 4, 5, 6, 7, 8, 9 };

            int[] commonElements = new int[array1.Length];
            int commonCount = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (IsInArray(array2, array1[i]) && !IsInArray(commonElements, array1[i]))
                {
                    commonElements[commonCount] = array1[i];
                    commonCount++;
                }
            }
            
            Console.WriteLine("Загальні елементи без повторень:");
            for (int i = 0; i < commonCount; i++)
            {
                Console.Write(commonElements[i] + " ");
            }
        }

        static bool IsInArray(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
