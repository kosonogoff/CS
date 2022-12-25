// ещё больше методов!!!

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        // index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // "-1" используем для случев, если нет нужного элемента в массиве

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // останавливаем цикл, если у нас в массиве есть несколько одинаковых элементов
        }
        index++;
    }
    return position;
}

int [] array = new int[12]; // здесь указываем длину массива

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 10);
Console.WriteLine(pos);