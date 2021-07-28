using System;
using System.Text;

public class Program 
{
    public static string ReverseCase(string str)
    {
      var newString = new StringBuilder();

      foreach (var chr in str)
      {
        if (chr.Equals(Char.ToUpper(chr)))
        {
          newString.Append(Char.ToLower(chr));
        }
        else
        {
          newString.Append(Char.ToUpper(chr));
        }
      }

      return newString.ToString();
    }
}
