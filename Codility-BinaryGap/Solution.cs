using System.Runtime.CompilerServices;

namespace Codility_BinaryGap
{
    public class Solution
    {
        private const int RANGE_LOWEST_VALUE = 1;
        private const int RANGE_HIGHEST_VALUE = 2147483647;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int N)
        {
            int maxGap = 0;

            // we have to check if the number is
            // in that specific range we wrote in Program.Main() function
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE)   
            {
                int currentGap = 0;
                bool counting = false;

                while (N > 0)
                {
                    if ((N & 1) == 1)
                    { // Check if the rightmost bit is 1
                        if (counting)
                        {
                            maxGap = Math.Max(maxGap, currentGap);
                            currentGap = 0;
                        }
                        counting = true;
                    }
                    else
                    {
                        if (counting)
                            currentGap++;
                    }
                    N = N >> 1; // Right shift N by 1
                }
            }
            
            return maxGap;
        }
    }
}
