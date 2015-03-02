namespace ProjectEuler
{
  public static class Utils
  {
    /// <summary>
    ///   Aux method that returs if a number is prime or not.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsPrime(long number)
    {
      if (number < 2) return false;
      if (number == 2) return true;

      for (int i = 3; (i*i) <= number; i += 2) if ((number%i) == 0) return false;
      return number != 1;
    }
  }
}