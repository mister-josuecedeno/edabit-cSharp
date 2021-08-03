public static int CharCount(char myChar, string str)
{
  int count = 0;

  foreach (var chr in str)
  {
    if (chr == myChar)
    {
      count++;
    }
  }

  return count;
}