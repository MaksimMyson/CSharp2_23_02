namespace CSharp2_23_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть розмір масиву:");
            string input = Console.ReadLine();

            int n;
            if (int.TryParse(input, out n))
            {
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

                Console.WriteLine("\nПарні елементи масиву:");
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }

                Console.WriteLine("\nНепарні елементи масиву:");
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }

                Console.WriteLine("\nУнікальні елементи масиву:");

                for (int i = 0; i < n; i++)
                {
                    bool isUnique = true;

                    for (int j = 0; j < n; j++)
                    {
                        if (arr[i] == arr[j] && i != j)
                        {
                            isUnique = false;
                            break;
                        }
                    }

                    if (isUnique)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Некоректний ввід. Будь ласка, введіть ціле число для розміру масиву.");
            }
        }
    }
}