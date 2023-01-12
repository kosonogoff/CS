// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке

int[] FillRandomArray(int size)
{
    int[] arr = new int[size]; // выделили память для массива

    for (int i = 0; i < arr.Length; i++) // C# знает длину массива
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

int[] array = FillRandomArray(8);
Console.WriteLine($"[{string.Join(",", array)}]");