// SНапишите программу, которая принимает на вход трёхзначное ЦЕЛОЕ число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите целое трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int workNumber = number / 10;
int secondDigit = workNumber % 10;

Console.WriteLine ($"Вторая цифра введённого числа {secondDigit}");