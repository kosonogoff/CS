// Напишите программу, которая будет пришимать на вход два ЦЕЛЫЕ числа
// и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток деления

Console.Write("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB == 0)
{
    Console.WriteLine("Нельзя делить на ноль!");
}

if (numberB > numberA)

{
    Console.WriteLine("Второе число больше первого. Повторите ввод");
}

else
{
    int remainder = numberA % numberB; // остаток целочисленного деления второго числа на первое

    if (remainder == 0)
        {
            Console.WriteLine("Второе число кратно первому");
        }

    if (remainder > 0)
        {
            Console.WriteLine($"Остаток деления {numberA} на {numberB} равен: {remainder}");
        }
}