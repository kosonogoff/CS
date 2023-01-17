// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива

int[] GetRandomArray (int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int MinMaxDiff (int[] array)
{
    int result = 0;
    int index = 1;
    int indexMin = 0;
    int min = array[indexMin];
    int indexMax = 0;
    int max = array[indexMax];

    while (index < array.Length)
    {
        if (array[index] < min)
        {
            min = array[index];
        }

        else if (array[index] > max)
        {
            max = array[index];
        }
        index++;
    }
    
    // Console.WriteLine($"min = {min}"); Console.WriteLine($"max = {max}"); // добавил временно для проверки корректности работы метода
    result = max - min;
    return result;
}

int size = new Random().Next(2, 51); // создадим массив с количеством 1-25 элементов
const int min = -100;
const int max = 100;
int result = 0; // сюда пропишем результат работы программы

int[] massive = GetRandomArray (size, min, max);
Console.WriteLine($"Данный массив: [{string.Join(", ", massive)}]");

result = MinMaxDiff (massive);
Console.WriteLine(); // снова пустая строка для красоты
Console.WriteLine($"Разница между min и max элементом массива равна {result}");