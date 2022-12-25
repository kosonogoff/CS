// пишем функцию нахождения максимального числа

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a = 13839;
int b = 21;
int c = 669299;
int d = 81;
int e = 48631;
int f = 54;
int g = 980;
int h = 20987789;
int i = 9123;

// int max1 = Max(a, b, c);
// int max2 = Max(d, e, f);
// int max3 = Max(g, h, i);
// int max = Max(max1, max2, max3);

int max = Max(Max(a, b, c), Max(d, e, f), Max(g, h, i)); // строки 21-24, но компактнее

Console.Write("max = ");
Console.WriteLine(max);