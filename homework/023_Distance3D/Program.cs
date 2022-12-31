// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.Write("Введите значение X для первой точки: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Y для первой точки: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Z для первой точки: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение X для второй точки: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Y для второй точки: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Z для второй точки: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"Расстояние между точками равняется {Math.Round(result, 2)}");