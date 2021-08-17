using System;

public class Program
{
  public static int CounterpartCharCode(char symbol)
  {
    var opposite = char.IsUpper(symbol) ? char.ToLower(symbol) : char.ToUpper(symbol);
    var oppositeCode = Convert.ToInt32(opposite);

    return oppositeCode;
  }
}