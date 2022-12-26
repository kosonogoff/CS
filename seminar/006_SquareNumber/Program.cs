// Напишите программу, которая принимает на вход два ЦЕЛЫХ числа 
// и проверяет, является ли одно число квадратом другого.

Console.Write("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA < numberB)
{
    int result = numberB % numberA;
    if (result == 0)
    {
        Console.WriteLine($"Да, число {numberB} является квадратом числа {numberA}");
    }

    else
    {
        Console.WriteLine($"Нет, число {numberB} не является квадратом числа {numberA}");
    }
}

else
{
    int temp = numberA;
    numberA = numberB;
    numberB = temp;
    int result = numberB % numberA;
    if (result == 0)
    {
        Console.WriteLine($"Да, число {numberB} является квадратом числа {numberA}");
    }

    else
    {
        Console.WriteLine($"Нет, число {numberB} не является квадратом числа {numberA}");
    }
}