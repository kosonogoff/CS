// Напишите программу замены элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.

int[] GetRandomArray (int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange +1);
    }
    return array;
}

const int size = 10;
const int leftRange = -100;
const int rightRange = 100;

int[] massive = GetRandomArray (size, leftRange, rightRange);
Console.Write("Данный массив: [");
Console.Write(string.Join(", ", massive));
Console.WriteLine("]");

int[] ArrayReplacement (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

massive = ArrayReplacement (massive);
Console.Write("Новый массив: [");
Console.Write(string.Join(", ", massive));
Console.WriteLine("]");