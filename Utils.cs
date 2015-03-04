using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
  public static class Utils
  {
    /// <summary>
    ///   Aux method that returs if a num is prime or not.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsPrime(long number)
    {
      if (number <= 1) return false;
      if (number < 4) return true;
      if (number%2 == 0) return false;
      if (number < 9) return true;
      if (number%3 == 0) return false;

      for (int i = 5; (i*i) <= number; i += 6) {
        if (number%i == 0) return false;
        if (number%(i + 2) == 0) return false;
      }
      return true;
    }

    public static BigInteger Factorial(int n)
    {
      BigInteger result = 1;
      for (long i = 2; i <= n; i++) result *= i;
      return result;
    }

    /// <summary>
    ///   The length of the repetend (period of the repeating decimal) of 1/p is
    ///   equal to the order of 10 modulo p.
    ///   Source Wikipedia: http://en.wikipedia.org/wiki/Repeating_decimal
    /// </summary>
    /// <param name="d"></param>
    /// <returns></returns>
    public static int RecurringCycle(int d)
    {
      for (int i = 1; i <= d; i++) {
        BigInteger res = BigInteger.ModPow(10, i, d);
        if (1 == res) return i;
      }
      return 0;
    }

    public static BigInteger SumDigits(BigInteger number)
    {
      BigInteger sum = 0;
      while (number >= 1) {
        BigInteger digit = number%10;
        sum = sum + digit;
        number /= 10;
      }
      return sum;
    }

    public static int SumDivisors(int num)
    {
      HashSet<int> divs = new HashSet<int> {1};
      int d = 2;
      while ((d*d) <= num) {
        if (num%d == 0) {
          int q = num/d;
          divs.Add(d);
          divs.Add(q);
        }
        d++;
      }
      return divs.Sum();
    }

    public static bool IsAbundant(int num)
    {
      return SumDivisors(num) > num;
    }

    public static int CharSum(this string s)
    {
      int sum = 0;
      string upper = s.ToUpperInvariant();
      foreach (char c in upper) sum += c - 64;
      return sum;
    }

    public static IEnumerable<string> StringPermutations(string prefix, string str)
    {
      int n = str.Length;
      if (n == 0) yield return prefix;
      else {
        for (int i = 0; i < n; i++) {
          foreach (var stringPermutation in 
            StringPermutations(prefix + str[i],
              str.Substring(0, i) + str.Substring(i + 1)))
            yield return stringPermutation;
        }
      }
    }

    public static IEnumerable<BigInteger> IntegerDigits(BigInteger number)
    {
      while (number >= 1) {
        BigInteger digit = number%10;
        number /= 10;
        yield return digit;
      }
    }
  }
}