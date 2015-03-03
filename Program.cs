using System;

namespace ProjectEuler
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      RunSet2();
    }

    private static void RunSet1()
    {
      Console.WriteLine("Sum of multiples of 3 and 5");
      Console.WriteLine("below 1000 = {0}", Set1.Prob1());

      Console.WriteLine();
      Console.WriteLine("Sum of even Fibonacci terms not exceeding 4M");
      Console.WriteLine(Set1.Prob2());

      Console.WriteLine();
      Console.WriteLine("Largest prime factor");
      Console.WriteLine("of 13195 = {0}",
        Set1.Prob3(13195));

      Console.WriteLine("of 600851475143 = {0}",
        Set1.Prob3());

      Console.WriteLine();
      Console.WriteLine("Largest palindrome product");
      Console.WriteLine("of two 3-digit numbers = {0}",
        Set1.Prob4(3));

      Console.WriteLine();
      Console.WriteLine("Smallest multiple");
      Console.WriteLine("up to 10 = {0}", Set1.Prob5(10));
      Console.WriteLine("up to 20 = {0}", Set1.Prob5());

      Console.WriteLine();
      Console.WriteLine("Sum square difference");
      Console.WriteLine("of 10 = {0}", Set1.Prob6(10));
      Console.WriteLine("of 100 = {0}", Set1.Prob6());

      Console.WriteLine();
      Console.WriteLine("The 10001st prime");
      Console.WriteLine("6th prime = {0}", Set1.Prob7(6));
      Console.WriteLine("1000th prime = {0}", Set1.Prob7(1000));
      Console.WriteLine("10001st prime = {0}", Set1.Prob7());

      Console.WriteLine();
      Console.WriteLine("Largest product in a series");
      Console.WriteLine("Product of 4 = {0}", Set1.Prob8(4));
      Console.WriteLine("Product of 13 = {0}", Set1.Prob8());

      Console.WriteLine();
      Console.WriteLine("Special Pythagorean triplet");
      Console.WriteLine("for sum(a,b,c)=12, a*b*c = {0}", Set1.Prob9(12));
      Console.WriteLine("for sum(a,b,c)=1000, a*b*c = {0}", Set1.Prob9());

      Console.WriteLine();
      Console.WriteLine("Summation of primes");
      Console.WriteLine("Sum of primes up to 20 = {0}", Set1.Prob10(20));
      Console.WriteLine("Sum of primes up to 2M = {0}", Set1.Prob10());
    }

    private static void RunSet2()
    {
      Console.WriteLine("Largest product in a grid");
      Console.WriteLine("result = {0}", Set2.Prob11());

      Console.WriteLine();
      Console.WriteLine("Triangular number with over 500 divisors");
      Console.WriteLine(Set2.Prob12());

      Console.WriteLine();
      Console.WriteLine("First 10 digits of large sum");
      Console.WriteLine(Set2.Prob13());

      Console.WriteLine();
      Console.WriteLine("Longest Collatz sequence for n < 1M");
      Console.WriteLine(Set2.Prob14());

      Console.WriteLine();
      Console.WriteLine("Lattice paths on a square matrix of size 20");
      Console.WriteLine(Set2.Prob15());

      Console.WriteLine();
      Console.WriteLine("Digit sum of the 1000th power of 2");
      Console.WriteLine(Set2.Prob16());

      Console.WriteLine();
      Console.WriteLine("Count the letters in the first 1000 numbers");
      Console.WriteLine(Set2.Prob17());

      Console.WriteLine();
      Console.WriteLine("Path of triangle with the greatest sum");
      Console.WriteLine(Set2.Prob18());

      Console.WriteLine();
      Console.WriteLine("Count the sundays on the first of any month of the 21th century");
      Console.WriteLine(Set2.Prob19());

      Console.WriteLine();
      Console.WriteLine("Sum the digits of 100!");
      Console.WriteLine(Set2.Prob20());
    }
  }
}