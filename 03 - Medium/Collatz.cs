public class Program
{
  public static int collatz(int num)
  {
    int k = num % 2 < 1 ? num / 2 : 3 * num + 1;
    return num < 2 ? 0 : collatz(k) + 1;
  }
}