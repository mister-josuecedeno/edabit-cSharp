using System.Text.RegularExpressions;

public class Program
{
	public static string Bomb(string txt)
	{
			Regex regex = new Regex(@"bomb", RegexOptions.IgnoreCase);
			bool foundTheBomb = regex.IsMatch(txt);
			return foundTheBomb ? "Duck!!!" : "There is no bomb, relax.";
	}
}