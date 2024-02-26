using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2_23_02
{
    public class Exercise2
    {
        public static int CountElementsGreaterThan(int[] arr, int threshold)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num > threshold)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
