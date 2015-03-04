using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Threading.Tasks;

namespace ProjectEuler
{
  internal static class Set3
  {
    /// <summary>
    ///   Euler project, problem 21.
    ///   Amicable numbers
    /// </summary>
    public static BigInteger Prob21(int limit = 10000)
    {
      int total = 0;
      for (int i = 1; i < limit; i++) {
        int sum1 = Utils.SumDivisors(i);
        int sum2 = Utils.SumDivisors(sum1);
        if (sum2 == i && sum1 != sum2) total += i;
      }
      return total;
    }

    /// <summary>
    ///   Euler project, problem 22.
    ///   Names scores
    /// </summary>
    /// <returns></returns>
    public static int Prob22()
    {
      string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/p022_names.txt";
      string fileAsTxt = File.ReadAllText(filePath);

      string[] names = fileAsTxt.Replace("\"", "").Trim().Split(',');

      SortedDictionary<string, int> namesWorths = new SortedDictionary<string, int>();
      foreach (string name in names) namesWorths.Add(name, name.CharSum());

      int sum = 0;
      for (int i = 0; i < namesWorths.Count; i++)
        sum += namesWorths.ElementAt(i).Value*(i + 1);

      return sum;
    }

    /// <summary>
    ///   Euler project, problem 23.
    ///   Non-abundant sums
    /// </summary>
    /// <returns></returns>
    public static BigInteger Prob23(int limit = 28123)
    {
      int sumAll = 0;
      List<int> abundantNums = new List<int>();
      for (int i = 1; i <= limit; i++) {
        sumAll += i;
        if (Utils.IsAbundant(i)) abundantNums.Add(i);
      }

      HashSet<int> sumOfAbundants = new HashSet<int>();
      for (int i = 0; i < abundantNums.Count - 1; i++) {
        for (int j = 0; j < abundantNums.Count - 1; j++) {
          int tmpSum = abundantNums.ElementAt(i) + abundantNums.ElementAt(j);
          if (tmpSum <= limit) sumOfAbundants.Add(tmpSum);
        }
      }

      return sumAll - sumOfAbundants.Sum();
    }

    /// <summary>
    ///   Euler project, problem 24.
    ///   Lexicographic permutations
    /// </summary>
    /// <returns></returns>
    public static string Prob24(int order = 1000000)
    {
      int count = 0;
      string result = "";
      foreach (var perm in Utils.StringPermutations("", "0123456789")) {
        count++;
        if (count == order) {
          result = perm;
          break;
        }
      }
      return result;
    }

    /// <summary>
    ///   Euler project, problem 25.
    ///   1000-digit Fibonacci number
    /// </summary>
    /// <returns></returns>
    public static BigInteger Prob25()
    {
      BigInteger a = 0, b = 1, fib = 0;
      int count = 1;
      while (fib.ToString().Length < 1000) {
        count++;
        fib = a + b;
        BigInteger aux = a;
        a = b;
        b = aux + b;
      }
      return count;
    }

    /// <summary>
    ///   Euler project, problem 26.
    ///   Reciprocal cycles
    /// </summary>
    /// <returns></returns>
    public static int Prob26()
    {
      int lDen = 0, lRecSize = 0;
      for (int i = 1000; i > 1; i--) {
        int size = Utils.RecurringCycle(i);
        if (size > lRecSize) {
          lRecSize = size;
          lDen = i;
        }
      }
      return lDen;
    }

    /// <summary>
    ///   Euler project, problem 27.
    ///   Quadratic primes
    /// </summary>
    /// <returns></returns>
    public static int Prob27()
    {
      int bestProd = 0, maxPrimes = 0;
      for (int a = -999; a <= 999; a++) {
        for (int b = -999; b <= 999; b++) {
          int prod = a*b;
          int primeCount = 0;
          int n = 0;
          while (Utils.IsPrime((n*n) + a*n + b)) {
            primeCount++;
            n++;
          }
          if (primeCount > maxPrimes) {
            maxPrimes = primeCount;
            bestProd = prod;
          }
        }
      }
      return bestProd;
    }

    /// <summary>
    ///   Euler project, problem 28.
    ///   Number spiral diagonals.
    ///   Ulam spirals have repeatable patterns.
    /// </summary>
    /// <returns></returns>
    public static long Prob28(int size = 1001)
    {
      long sum = 1;
      long end = 1;
      int inc = 2;

      for (int i = 3; i <= size; i += 2) {
        long start = end + inc;
        end = start + (3*inc);
        sum += 2*(start + end);
        inc += 2;
      }
      return sum;
    }

    /// <summary>
    ///   Euler project, problem 29.
    ///   Distinct powers
    /// </summary>
    /// <returns></returns>
    public static int Prob29(int limit = 100)
    {
      HashSet<BigInteger> results = new HashSet<BigInteger>();
      for (int a = 2; a <= limit; a++) {
        for (int b = 2; b <= limit; b++) {
          BigInteger value = BigInteger.Pow(a, b);
          results.Add(value);
        }
      }
      return results.Count;
    }

    /// <summary>
    ///   Euler project, problem 30.
    ///   Digit fifth powers
    /// </summary>
    /// <returns></returns>
    public static long Prob30(int power = 5)
    {
      ConcurrentBag<long> results = new ConcurrentBag<long>();
      long limit = (long) (BigInteger.Pow(10, power + 1) - 1);

      Parallel.For(2, limit, i => {
        BigInteger sum = 0;
        foreach (BigInteger digit in Utils.IntegerDigits(i))
          sum += BigInteger.Pow(digit, power);
        if (sum == i) results.Add(i);
      });
      return results.Sum();
    }
  }
}