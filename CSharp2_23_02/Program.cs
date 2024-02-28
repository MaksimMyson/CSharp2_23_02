namespace SubstringCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть вихідний рядок:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Введіть підрядок для пошуку:");
            string searchString = Console.ReadLine();

            int occurrences = CountOccurrences(inputString, searchString);

            Console.WriteLine($"Результат пошуку: {occurrences}");
        }

        public static int CountOccurrences(string inputString, string searchString)
        {
            int count = 0;
            int currentIndex = 0;

            while ((currentIndex = inputString.IndexOf(searchString, currentIndex)) != -1)
            {
                count++;
                currentIndex += searchString.Length;
            }

            return count;
        }
    }
}