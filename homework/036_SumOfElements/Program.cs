// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях

int[] GetRandomArray (int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int GetSum (int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        result = result + array[i];
    }
    return result;
}

int size = new Random().Next(1, 51); // создадим массив с количеством 1-50 элементов
const int min = -100;
const int max = 100;
int result = 0; // сюда пропишем результат работы программы

int[] massive = GetRandomArray (size, min, max);
Console.WriteLine($"Данный массив: [{string.Join(", ", massive)}]");

result = GetSum (massive);
Console.WriteLine(); // снова пустая строка для красоты
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {result}");