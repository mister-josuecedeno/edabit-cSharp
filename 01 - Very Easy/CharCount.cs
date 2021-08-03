class Program
{
  public static int CharCount(char myChar, string str)
  {
    int count = 0;

    foreach (var chr in str)
    {
      if (chr == myChar)
      {
        count++;
      }
    }

    return count;
  }

  static void Main(string[] args)
  {
    Console.WriteLine(CharCount('a', "edabit"));
    Console.WriteLine(CharCount('b', "big fat bubble"));
    Console.WriteLine(CharCount('c', "Chamber of secrets"));
  }
}