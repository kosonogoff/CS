// Напишите программу, которая принимает на вход три ЦЕЛЫХ числа и выдаёт максимальное из этих чисел

Console.Write("Введите первое целое число: "); // запрос первого числа от пользователя
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: "); // запрос второго числа от пользователя
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: "); // запрос третьего числа от пользователя
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max)
    {
        max = numberB;
    }

if (numberC > max)
    {
        max = numberC;
    }

Console.Write($"Максимальное введённое число: {max}");