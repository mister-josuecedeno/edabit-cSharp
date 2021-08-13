using System;

public class Program
{
  public static string smallerNum(string n1, string n2)
  {
    int num1 = Int32.Parse(n1);
    int num2 = Int32.Parse(n2);

    if (num1 < num2)
    {
      return n1;
    }
    else if (num2 < num1)
    {
      return n2;
    }
    else
    {
      return n1;
    }

  }
}