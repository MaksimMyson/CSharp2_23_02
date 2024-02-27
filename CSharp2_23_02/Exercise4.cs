using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2_23_02
{
    public class Exercise4
    {
      public static int[] MergeArrays(int[] arr1, int[] arr2)
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
