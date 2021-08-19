using System;
using System.Collections.Generic;

public class Program
{
  public static int animals(int chickens, int cows, int pigs)
  {
    var legs = new Dictionary<string, int>()
    {
        { "chickens", 2 },
        { "cows", 4 },
        { "pigs", 4 }
    };

    return (chickens * legs["chickens"]) + (cows * legs["cows"]) + (pigs * legs["pigs"]);
  }
}