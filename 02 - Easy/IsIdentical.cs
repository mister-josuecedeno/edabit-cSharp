using System;
using System.Linq;

public class Program
{
  public static bool isIdentical(string str)
  {
    return str.All(c => c == str[0]);
  }
}