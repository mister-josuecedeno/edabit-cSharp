public class Program
{
  public static string NameShuffle(string str)
  {
    string[] words = str.Split(' ');
    return $"{words[1]} {words[0]}";
  }
}