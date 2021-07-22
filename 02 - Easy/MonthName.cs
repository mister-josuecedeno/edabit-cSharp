using System;
public class Program
{
  public static string MonthName(int num)
  {
    DateTime d = new DateTime(2021, num, 1);
    return d.ToString("MMMM");
  }
}