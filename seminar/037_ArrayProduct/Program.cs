// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

int[] GetRandomArray (int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

int size = new Random().Next(1, 10);
int leftRange = -10;
int rightRange = 10;

int[] massive = GetRandomArray (size, leftRange, rightRange);
Console.Write("Данный массив: [");
Console.Write(string.Join(", ", massive));
Console.WriteLine("]");

int sizeNew = massive.Length / 2 + massive.Length % 2;
int[] newArray = new int [sizeNew];

for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = massive[i] * massive[massive.Length - 1 - i];
}

if (massive.Length % 2 == 1)
{
    newArray[sizeNew - 1] = massive[massive.Length / 2];
}

Console.Write("Новый массив: [");
Console.Write(string.Join(", ", newArray));
Console.WriteLine("]");