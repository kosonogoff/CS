// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    Console.WriteLine("Нет такого дня недели");
}
else if (number == 1)
{
    Console.WriteLine("Нет, это не выходной. Неделя только началась((");
}
else if (number == 2)
{
    Console.WriteLine("Нет, это не выходной.");
}
else if (number == 3)
{
    Console.WriteLine("Нет, это не выходной, но уже середина рабочей недели");
}
else if (number == 4)
{
    Console.WriteLine("Нет, это не выходной, но скоро пятница");
}
else if (number == 5)
{
    Console.WriteLine("Нет, это не выходной. Осталось пережить только этот день)");
}
else if (number == 6)
{
    Console.WriteLine("Да, сегодня выходной!");
}
else if (number == 7)
{
    Console.WriteLine("Да, сегодня выходной!");
}
else if (number > 7)
{
    Console.WriteLine("Нет такого дня недели");
}
