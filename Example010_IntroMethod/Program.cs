int Max(int a, int b, int c)
{
    int max = a;
    if(b > max) max = b;
    if(c > max) max = c;
    return max;
}

int a1 = 35;
int b1 = 78;
int c1 = 25;
int a2 = 17;
int b2 = 97;
int c2 = 1025555;
int a3 = 455;
int b3 = 73;
int c3 = 95111;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);
