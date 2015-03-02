using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace ProjectEuler
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      RunSet1();
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
      Console.WriteLine("for sum(a,b,c)=1000, a*b*c = {0}", Set1.Prob9(1000));
    }
  }
}