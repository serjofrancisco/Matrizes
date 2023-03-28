using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    public class countEvenOdd
    {
        public int CountEvenOdd(int[,] matrix)
        {
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
            }

            return evenCount > oddCount ? evenCount : oddCount;
        }
    }
}
