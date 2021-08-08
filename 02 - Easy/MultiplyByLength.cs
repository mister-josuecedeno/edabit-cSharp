class Program
{
  public static int[] MultiplyByLength(int[] arr)
  {
    for (int i = 0; i < arr.Length; i++)
    {
      arr[i] = arr[i] * arr.Length;
    }

    return arr;
  }
}