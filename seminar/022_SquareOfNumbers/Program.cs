// Напишите программу, которая принимает на вход ЦЕЛОЕ число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

/* int start = 1;
int i = 1;
while (i <= number)
{
    Console.Write($"{Math.Pow(start, 2)} ");
    start++;
    i++;
} */

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i} ");
}