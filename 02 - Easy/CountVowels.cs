using System.Text.RegularExpressions;

public class Program 
{
    public static int CountVowels(string str)
		{
				string pattern = @"[aeiou]";
				Regex rg = new Regex(pattern);
				MatchCollection matches = rg.Matches(str);
				return matches.Count;
		}
}