using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
  internal static class Set4
  {
    /// <summary>
    ///   Euler project, problem 31.
    ///   Coin sums
    /// </summary>
    public static BigInteger Prob31(int limit = 10000)
    {
      int[] coins = new int[] {1,2,5,10,20,50,100,200};

      // Combinations
      for (int i = 1; i <= 7; i++) {
        for (int j = 1; j <= i; j++) {
          
        }
      }
      int total = 0;
      for (int i = 1; i < limit; i++)
      {
        int sum1 = Utils.SumDivisors(i);
        int sum2 = Utils.SumDivisors(sum1);
        if (sum2 == i && sum1 != sum2) total += i;
      }
      return total;
    }
  }
}
