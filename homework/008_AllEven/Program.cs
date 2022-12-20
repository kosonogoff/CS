// Напишите программу, которая на вход принимает ЦЕЛОЕ число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int start = 2;
int print = start;

Console.Write($"{print} ");

// сейчас цикл запустим
while (start < number - 1) 
{
    print = print + 2;
    Console.Write($"{print} ");
    start = start + 2;
}