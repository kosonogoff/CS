// теперь мы пишем ещё и массивы

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// индексы       0   1     2       3    4  5    6     7   8
int [] array = {12, 65, 7654, 124567, 123, 3, 765, 2346, 98};
int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
    );
Console.Write("max = ");
Console.WriteLine(max);