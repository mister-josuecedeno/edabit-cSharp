using System;

public class Program
{
  public static bool CheckPalindrome(string str)
  {
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    string reversed = new string(arr);

    return str == reversed;
  }
}