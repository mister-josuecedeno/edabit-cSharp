using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
  public static double[] FindLargest(double[][] values)
  {
    var result = new double[values.Length];

    for (int i = 0; i < values.Length; i++)
    {
      result[i] = values[i].Max();
    }

    return result;
  }
}