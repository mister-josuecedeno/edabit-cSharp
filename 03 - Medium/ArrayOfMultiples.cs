using System;

public class Program {
	public static int[] ArrayOfMultiples(int num, int length)
    {
      int[] result = new int[length];

      for (int i = 1; i <= length; i++)
      {
        result[i - 1] = num * i;
      }

      return result;
    }
}