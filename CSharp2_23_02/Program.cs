namespace CSharp2_23_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Random rand = new Random();

            int n = rand.Next(5, 10);
            int[] arr = new int[n];

            Console.WriteLine("Масив розміром N:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 100);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\n\nМасив розміром M:");

            int m = rand.Next(5, 10);
            int[] arr2 = new int[m];
            for (int i = 0; i < m; i++)
            {
                arr2[i] = rand.Next(1, 100);
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine("\n\nМасив розміром N+M:");
            int[] arr3 = MergeArrays(arr, arr2);

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }

        static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int n = arr1.Length;
            int m = arr2.Length;
            int[] mergedArray = new int[n + m];
            int mergedIndex = 0;

            
            for (int i = 0; i < n; i++)
            {
                mergedArray[mergedIndex++] = arr1[i];
            }

            
            for (int i = 0; i < m; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < n; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    mergedArray[mergedIndex++] = arr2[i];
                }
            }

            Array.Resize(ref mergedArray, mergedIndex); 
            return mergedArray;
        }
    }
}