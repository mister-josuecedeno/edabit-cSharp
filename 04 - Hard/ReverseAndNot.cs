using System;
using System.Linq;
public class Program
{
  public static string ReverseAndNot(int i)
  {
    var arr = i.ToString().ToCharArray();
    Array.Reverse(arr);
    var reversed = new string(arr);

    return $"{reversed}{i}";
  }
}