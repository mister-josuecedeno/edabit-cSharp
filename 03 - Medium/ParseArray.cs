using System.Linq;

public class Program
{
  public static string[] ParseArray(object[] arr)
  {
    return arr.Select(el => el.ToString()).ToArray();
  }
}