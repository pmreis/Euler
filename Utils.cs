using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler
{
  public class Node
  {
    public Node Left { get; set; }
    public Node Right { get; set; }
    public int Value { get; set; }
  }


  public static class Utils
  {
    /// <summary>
    ///   Aux method that returs if a number is prime or not.
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
      for (long i = 2; i <= n; i++) {
        result *= i;
      }
      return result;
    }

    public static BigInteger SumDigits(BigInteger number)
    {
      BigInteger sum = 0;
      while (number > 1)
      {
        BigInteger digit = number % 10;
        sum = sum + digit;
        number /= 10;
        if (number == 1) sum++;
      }
      return sum;
    }

    public static long MaxSumOfSubTree(Node n)
    {
      if (n == null) return 0;
      return n.Value + Math.Max(MaxSumOfSubTree(n.Left), MaxSumOfSubTree(n.Right));
    }

  }
}