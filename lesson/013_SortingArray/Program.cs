// Написать программу, которая отсортирует массив ЦЕЛЫХ чисел
// от минимального к максимальному

int[] array = {1, 3, 4, 7, 6, 1, 2, 4, 8, 9, 4, 1, 5};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // вопрос по проверке условия: почему -1?
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(array);
SortArray(array);
PrintArray(array);