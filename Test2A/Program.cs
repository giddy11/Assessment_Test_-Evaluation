// See https://aka.ms/new-console-template for more information

int[] arrays = new int[10] { 4, 8, 6, 7, 5, 9, 3, 6, 1, 2 };
int n = arrays.Length;

 static int FindMinNumber(int [] arrays, int n)
{
    if (n == 0) return arrays[0];

    return Math.Min(arrays[n - 1], FindMinNumber(arrays, n - 1));
}

static int FindMaxNumber(int[] arrays, int n)
{
    if (n == 0) return arrays[0];

    return Math.Max(arrays[n - 1], FindMaxNumber(arrays, n - 1));
}

Console.WriteLine($"The sum = {FindMaxNumber(arrays, n) + FindMinNumber(arrays, n)}");