// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0 || number > 4)
{
    Console.WriteLine("Такого номера четверти не существует");
}

if (number == 1)
{
    Console.WriteLine("Возможные координаты: X > 0, Y > 0");
}

if (number == 2)
{
    Console.WriteLine("Возможные координаты: X < 0, Y > 0");
}

if (number == 3)
{
    Console.WriteLine("Возможные координаты: X < 0, Y < 0");
}

if (number == 4)
{
    Console.WriteLine("Возможные координаты: X > 0, Y < 0");
}