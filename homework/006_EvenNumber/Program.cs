// Напишите программу, которая на вход принимает ЦЕЛОЕ число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 2) == 0)
{
    Console.WriteLine("Да, это число чётное!");
}
else
{
    Console.WriteLine("Нет, это число нечётное!");
}
