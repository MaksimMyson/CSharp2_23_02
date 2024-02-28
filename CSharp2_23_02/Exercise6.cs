using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2_23_02
{
    public class Exercise6
    {
        public static int CountLetters(string sentence)
        {
            int count = 0;

            foreach (char c in sentence)
            {
                if (char.IsLetter(c) || char.IsWhiteSpace(c))
                {
                    count++;
                }
            }

            return count;
        }

    }
}
