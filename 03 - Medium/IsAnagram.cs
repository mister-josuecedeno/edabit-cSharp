using System;
using System.Linq;

public class Program 
{
    public static bool IsAnagram(string str1, string str2)
    {
      char[] chr1 = str1.ToLower().ToArray();
      Array.Sort(chr1);
      var sortedStr1 = new string(chr1);

      char[] chr2 = str2.ToLower().ToArray();
      Array.Sort(chr2);
      var sortedStr2 = new string(chr2);

      return sortedStr1 == sortedStr2;
    }
}
