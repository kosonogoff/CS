// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] GetRandomArray (int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void Reverse (int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

int size = new Random().Next(5, 10);
const int min = -10;
const int max = 10;
int[] massive = GetRandomArray(size, min, max);
Console.WriteLine($"Данный массив: [{string.Join(", ", massive)}]");
Reverse(massive);
Console.WriteLine($"Новый массив: [{string.Join(", ", massive)}]");