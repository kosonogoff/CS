int [] array = {1, 35, 76, 12, 867, 456, 765, 1, 2150};
int n = array.Length;
int find = 1;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}