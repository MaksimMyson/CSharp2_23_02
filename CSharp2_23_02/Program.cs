namespace CSharp2_23_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть розмір масиву:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 100);
            }

            Console.WriteLine("Масив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nВведіть число для порівняння:");
            int x = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > x)
                {
                    count++;
                }
            }

            Console.WriteLine("Кількість елементів більших за " + x + " = " + count);


        }
    }
}
