using System;
using System.Collections;

public class Program
{
  public static string HackerSpeak(string str)
  {
    var letters = new char[str.Length];

    var values = new Hashtable()
        {
            { 'a', '4' },
            { 'e', '3'},
            { 'i', '1' },
            { 'o', '0' },
            { 's', '5' }
        };

    for (int i = 0; i < str.Length; i++)
    {
      var letter = values[str[i]] != null ? values[str[i]] : str[i];
      letters[i] = (char)letter;
    }

    return new string(letters);
  }
}