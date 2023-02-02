// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. m = 2, n = 3 -> A(m,n) = 9

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

long Akkerman(long x, long y)
{

    if (x == 0) return y + 1;
    else if (x > 0 && y == 0) return Akkerman(x - 1, 1);
    else if (x > 0 && y > 0) return Akkerman(x - 1, Akkerman(x, y - 1));
    return 0;

}

long m = ReadNumber("Введите число: ");
long n = ReadNumber("Введите число: ");

if (m < 0 || n < 0) Console.WriteLine("Функция не работает с отрицательными числами!");

else
{
    Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");
}