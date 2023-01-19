// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1

int ReadNumber(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int[] GetFibonacci (int size)
{
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

int number = ReadNumber("Введите число: ");
int[] fibonacci = GetFibonacci(number);

// печатаем ряд Фибоначчи на экране
for (int i = 0; i < fibonacci.Length; i++)
{
    Console.Write($"{fibonacci[i]} ");
}