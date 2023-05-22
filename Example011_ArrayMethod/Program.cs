int Max(int a, int b, int c)
{
    int max = a;
    if(b > max) max = b;
    if(c > max) max = c;
    return max;
}
int[] array={15, 72, 390, 74, 56, 69, 97, 18, 179};

int max = Max(Max(array[0], array[1], array[2]),
          Max(array[3], array[4], array[5]),
          Max(array[6], array[7], array[8]));

Console.WriteLine(max);
