using System.Linq;
public class Program
{
  public static int[] SortNumsAscending(int[] arr)
  {
    return arr.OrderBy(n => n).ToArray();
  }
}