namespace CSharp2_23_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            double[] A = new double[5];

            
            double[,] B = new double[3, 4];

            
            Console.WriteLine("Введіть елементи одновимірного масиву A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}]: ");
                A[i] = double.Parse(Console.ReadLine());
            }

            
            Random rand = new Random();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = rand.NextDouble() * 100; 
                }
            }

            
            Console.WriteLine("Масив A:");
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            
            Console.WriteLine("Масив B:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }

            
            double maxA = A[0];
            double maxB = B[0, 0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > maxA)
                    maxA = A[i];
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > maxB)
                        maxB = B[i, j];
                }
            }
            Console.WriteLine($"Максимальний елемент у масиві А: {maxA}");
            Console.WriteLine($"Максимальний елемент у масиві В: {maxB}");

            
            double minA = A[0];
            double minB = B[0, 0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < minA)
                    minA = A[i];
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] < minB)
                        minB = B[i, j];
                }
            }
            Console.WriteLine($"Мінімальний елемент у масиві А: {minA}");
            Console.WriteLine($"Мінімальний елемент у масиві В: {minB}");

            
            double sumA = 0;
            double sumB = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sumA += A[i];
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    sumB += B[i, j];
                }
            }
            Console.WriteLine($"Загальна сума елементів масиву А: {sumA}");
            Console.WriteLine($"Загальна сума елементів масиву В: {sumB}");

            
            double productA = 1;
            double productB = 1;
            for (int i = 0; i < A.Length; i++)
            {
                productA *= A[i];
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    productB *= B[i, j];
                }
            }
            Console.WriteLine($"Загальний добуток елементів масиву А: {productA}");
            Console.WriteLine($"Загальний добуток елементів масиву В: {productB}");

            
            double evenSumA = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i % 2 == 0)
                    evenSumA += A[i];
            }
            Console.WriteLine($"Сума парних елементів масиву А: {evenSumA}");

            
            double oddColumnSumB = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < B.GetLength(0); i++)
                    {
                        oddColumnSumB += B[i, j];
                    }
                }
            }
            Console.WriteLine($"Сума елементів непарних стовпців масиву В: {oddColumnSumB}");

            Console.ReadLine(); 
        }
    }
}
