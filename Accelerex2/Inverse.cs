using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accelerex2
{
    public class Inverse
    {
        public static void InversePerm(int size, int[] arr)
        {
            int i, j;
            for (i = 0; i < size; i++)
            {

                for (j = 0; j < size; j++)
                {

                    if (arr[j] == i + 1)
                    {
                        Console.Write(j + 1 + " ");
                        break;
                    }
                }
            }
        }
    }
}
