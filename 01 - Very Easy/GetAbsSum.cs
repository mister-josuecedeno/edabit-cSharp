using System;

public class Program 
{
    public static int GetAbsSum(int[] arr)
		{
				int sum = 0;

				foreach (var n in arr)
				{
						sum += Math.Abs(n);
				}

				return sum;
		}
}