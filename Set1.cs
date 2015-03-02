using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectEuler
{
  /// <summary>
  ///   Contains the solutions for the first 10 problems posed on the Project Euler.
  ///   https://projecteuler.net/
  /// </summary>
  internal static class Set1
  {
    /// <summary>
    ///   Euler project, problem 1.
    ///   Return the sum of all numbers multiple of 3 or 5 below a certain limit.
    /// </summary>
    /// <param name="limit"></param>
    /// <returns></returns>
    public static int Prob1(int limit = 1000)
    {
      int sum = 0;
      for (int i = 1; i < limit; i++) if (i%3 == 0 || i%5 == 0) sum += i;
      return sum;
    }

    /// <summary>
    ///   Euler project, problem 2.
    ///   Returns the sum of all even Fibonacci terms not exceeding 4M.
    /// </summary>
    /// <returns></returns>
    public static int Prob2(int limit = 4000000)
    {
      int total = 0, a = 0, b = 1;
      int sum = a + b;
      for (int i = 1; sum < limit; i++) {
        total += (sum%2 == 0) ? sum : 0;
        int tmp = b;
        b = a + b;
        a = tmp;
        sum = a + b;
      }
      return total;
    }

    /// <summary>
    ///   Euler project, problem 3.
    ///   Find the lastest prime factor of 600851475143.
    ///   Rational: every positive integer is factored by primes. If
    ///   a positive integer is evenly divided repeatedly it will become
    ///   its largest prime factor.
    /// </summary>
    public static int Prob3(long value = 600851475143)
    {
      int startDivisor = 2;
      int largestPrime = 2;

      while (value > 1) {
        if (value%startDivisor == 0) {
          value = value/startDivisor;
          if (startDivisor > largestPrime) largestPrime = startDivisor;
          startDivisor = 2;
        }
        else startDivisor++;
      }

      return largestPrime;
    }

    /// <summary>
    ///   Euler project, problem 4.
    ///   Returns the largest palindrome product of two 3-digit numbers.
    /// </summary>
    /// <returns></returns>
    public static int Prob4(int digits)
    {
      int largest = 0;
      int limit = (int) Math.Pow(10, digits);

      for (int i = 100; i < limit; i++) {
        for (int j = 100; j < limit; j++) {
          int prod = i*j;
          int num = prod;
          int rev = 0;
          while (num > 0) {
            int digit = num%10;
            rev = rev*10 + digit;
            num = num/10;
          }
          if (rev == prod && prod > largest) largest = prod;
        }
      }
      return largest;
    }

    /// <summary>
    ///   Euler project, problem 5.
    ///   Returns the smallest positive number evenly divisible by all of the numbers from 1 to 20
    /// </summary>
    public static int Prob5(int upTo = 20)
    {
      for (int i = 21; i < int.MaxValue; i++) {
        bool divisible = true;
        for (int j = 2; j < upTo; j++) {
          if (i%j != 0) {
            divisible = false;
            break;
          }
        }
        if (divisible) return i;
      }
      return -1;
    }

    /// <summary>
    ///   Euler project, problem 6.
    ///   Returns the difference between the square of the sum and the
    ///   sum of the squares.
    /// </summary>
    public static int Prob6(int upTo = 100)
    {
      int sumOfSquares = 0;
      int squareOfSums = 0;

      for (int i = 1; i <= upTo; i++) {
        squareOfSums += i;
        sumOfSquares += i*i;
      }

      squareOfSums = squareOfSums*squareOfSums;
      return squareOfSums - sumOfSquares;
    }

    /// <summary>
    ///   Euler project, problem 7.
    ///   Returns the 10 001st prime number
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public static long Prob7(int order = 10001)
    {
      int count = 0;
      long num = 2;

      while (count < order) {
        if (Utils.IsPrime(num)) count++;
        num++;
      }
      return num - 1;
    }

    /// <summary>
    ///   Euler project, problem 8.
    ///   Returns the largest product of 13 digits within 1000 digits.
    /// </summary>
    /// <param name="qnt"></param>
    /// <returns></returns>
    public static long Prob8(int qnt = 13)
    {
      string num = @"73167176531330624919225119674426574742355349194934
                     96983520312774506326239578318016984801869478851843
                     85861560789112949495459501737958331952853208805511
                     12540698747158523863050715693290963295227443043557
                     66896648950445244523161731856403098711121722383113
                     62229893423380308135336276614282806444486645238749
                     30358907296290491560440772390713810515859307960866
                     70172427121883998797908792274921901699720888093776
                     65727333001053367881220235421809751254540594752243
                     52584907711670556013604839586446706324415722155397
                     53697817977846174064955149290862569321978468622482
                     83972241375657056057490261407972968652414535100474
                     82166370484403199890008895243450658541227588666881
                     16427171479924442928230863465674813919123162824586
                     17866458359124566529476545682848912883142607690042
                     24219022671055626321111109370544217506941658960408
                     07198403850962455444362981230987879927244284909188
                     84580156166097919133875499200524063689912560717606
                     05886116467109405077541002256983155200055935729725
                     71636269561882670428252483600823257530420752963450";

      long prod = 1, largest = 0;
      num = String.Join("", num.Split());
      for (int i = 0; i < num.Length - qnt; i++) {
        long val = Convert.ToInt64(num.Substring(i, qnt));
        long tmpVal = val;
        long tmpProd = 1;
        while (tmpVal > 0) {
          long digit = tmpVal%10;
          tmpProd = tmpProd*digit;
          tmpVal = tmpVal/10;
        }
        if (tmpProd > prod) {
          prod = tmpProd;
          largest = val;
        }
      }
      Console.WriteLine("Largest = {0}", largest);
      return prod;
    }

    /// <summary>
    ///   Euler project, problem 9.
    ///   Returns the product of a Pythagorean triplet for which a+b+c=1000
    /// </summary>
    public static int Prob9(int find = 1000)
    {
      for (int a = 2; a < find - 2; a++) {
        for (int b = a + 1; b < find - 1; b++) {
          int sC = a*a + b*b;
          int c = (int) Math.Sqrt(sC);
          if (a*a + b*b == c*c && a + b + c == find) return a*b*c;
        }
      }
      return -1;
    }

    /// <summary>
    ///   Euler project, problem 10.
    ///   Find the sum of all the primes below two million.
    /// </summary>
    public static long Prob10(int limit = 2000000)
    {
      long sum = 2;

      Parallel.For(3, limit, i =>
      {
        if (i%2 != 0) {
          if (Utils.IsPrime(i)) {
            Interlocked.Add(ref sum, i);
          }
        }
      });

      return sum;
    }


  }
}