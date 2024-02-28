using System.Text;

namespace CSharp2_23_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            int[,] matrix1 = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int[,] matrix2 = {
                {9, 8, 7},
                {6, 5, 4},
                {3, 2, 1}
            };

            int scalar = 2; 

            
            Console.WriteLine("Матриця 1:");
            PrintMatrix(matrix1);

            Console.WriteLine("\nМатриця 2:");
            PrintMatrix(matrix2);

            
            Console.WriteLine("\nМноження матриці 1 на число:");
            int[,] result1 = MultiplyByScalar(matrix1, scalar);
            PrintMatrix(result1);

            Console.WriteLine("\nДодавання матриць:");
            int[,] result2 = AddMatrices(matrix1, matrix2);
            PrintMatrix(result2);

            Console.WriteLine("\nДобуток матриць:");
            int[,] result3 = MultiplyMatrices(matrix1, matrix2);
            PrintMatrix(result3);

            Console.ReadLine(); 
        }

        
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        
        static int[,] MultiplyByScalar(int[,] matrix, int scalar)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }

            return result;
        }

        
        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        
        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int cols2 = matrix2.GetLength(1);
            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }
    }
}
