using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2_23_02
{
    public class Exercise1
    {
        public static int[] GetEvenNumbers(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).ToArray();
        }

        public static int[] GetOddNumbers(int[] arr)
        {
            return arr.Where(x => x % 2 != 0).ToArray();
        }

        public static int[] GetUniqueNumbers(int[] arr)
        {
            return arr.Distinct().ToArray();
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}

