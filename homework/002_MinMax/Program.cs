// Напишите программу, которая на вход принимает два ЦЕЛЫХ числа и выдаёт, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое целое число: "); // запрос первого числа от пользователя
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: "); // запрос второго числа от пользователя
int numberB = Convert.ToInt32(Console.ReadLine());

int min = numberA;
int max = numberB;

if (max > min)
{
Console.WriteLine($"Минимальное число: {min}"); // вывод результата
Console.WriteLine($"Максимальное число: {max}");
}
else
{
    min = numberB;
    max = numberA;

Console.WriteLine($"Минимальное число: {min}"); // вывод результата
Console.WriteLine($"Максимальное число: {max}");
}