﻿// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X и Y не равны нулю
// и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите значение X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Координаты не могут равняться нулю");
    return; // завершит работу программы
}

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится в второй четверти");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвёртой четверти");
}