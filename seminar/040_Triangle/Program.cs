// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число: ");
int c = Convert.ToInt32(Console.ReadLine());

bool Treangle (int x, int y, int z)
{
    if ( (x+y>z) && (x+z>y) && (z+y>x))
    {
        return true;
    }

    return false;
}

Console.WriteLine($"Такой треугольyик существует: {Treangle(a, b, c)}");