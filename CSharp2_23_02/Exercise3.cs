using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2_23_02
{
    public class Exercise3
    {
        public static int CountSequenceOccurrences(int[] array, int num1, int num2, int num3)
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
