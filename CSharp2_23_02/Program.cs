namespace CSharp2_23_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть перше число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть третє число:");
            int num3 = int.Parse(Console.ReadLine());

            int[] array = new int[] { num1, num2, num3, 3, 4, num1, num2, num3, 8, num1, num2, num3 }; // Приклад масиву
            Console.WriteLine("Масив: " + string.Join(" ", array));

            int count = CountSequenceOccurrences(array, num1, num2, num3);

            Console.WriteLine($"Кількість входжень послідовності {num1}, {num2}, {num3} в масиві: {count}");
        }

        static int CountSequenceOccurrences(int[] array, int num1, int num2, int num3)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i] == num1 && array[i + 1] == num2 && array[i + 2] == num3)
                {
                    count++;
                }
            }
            return count;
        }
    }
}