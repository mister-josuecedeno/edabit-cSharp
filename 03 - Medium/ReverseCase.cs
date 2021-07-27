public class Program
{
  public static string ReverseCase(string str)
  {
    var newString = new StringBuilder();

    foreach (var chr in str)
    {
      Console.WriteLine(chr);
    }

    return newString.ToString();
  }
}
