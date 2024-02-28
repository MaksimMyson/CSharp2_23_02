namespace CSharp2_23_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;    
            int[,] array = new int[5, 5];
            Random random = new Random();

            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 101); 
                }
            }

            
            Console.WriteLine("Двовимірний масив:");
            PrintArray(array);

            
            int minRowIndex = 0, minColIndex = 0;
            int maxRowIndex = 0, maxColIndex = 0;
            int minValue = array[0, 0];
            int maxValue = array[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < minValue)
                    {
                        minValue = array[i, j];
                        minRowIndex = i;
                        minColIndex = j;
                    }

                    if (array[i, j] > maxValue)
                    {
                        maxValue = array[i, j];
                        maxRowIndex = i;
                        maxColIndex = j;
                    }
                }
            }

            
            int sum = 0;
            int startRow = Math.Min(minRowIndex, maxRowIndex) + 1;
            int endRow = Math.Max(minRowIndex, maxRowIndex) - 1;
            int startCol = Math.Min(minColIndex, maxColIndex) + 1;
            int endCol = Math.Max(minColIndex, maxColIndex) - 1;

            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    sum += array[i, j];
                }
            }

            
            Console.WriteLine($"Сума елементів між мінімальним ({minValue}) та максимальним ({maxValue}) елементами: {sum}");

            Console.ReadLine(); 
        }

        
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j],4} ");
                }
                Console.WriteLine();
            }
        }
    }
}
