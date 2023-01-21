double Factorial (int n)
// разбираемся в рекурсии на примере факториала
{
    // 1! = 1
    // 0! = 1

    if (n == 1) return 1;
    else return n * Factorial (n - 1);
}

int Fibonacci (int n)
// разбираемся в рекурсии на примере чисел Фибаначчи
{
    // f(1) = 1
    // f(2) = 1
    // f(n) = f(n - 1) + f(n - 2)

    if (n == 1 || n == 2) return 1;
    else return Fibonacci (n - 1) + Fibonacci (n - 2);
}

Console.WriteLine($"Проверим работу факториала");
for (int i = 1; i < 40; i++) // проверим работу факториала на больших числах
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

Console.WriteLine($"Сделаем вычисление чисел Фибоначчи");
for (int i = 1; i < 40; i++) // проверим работу для вычисления чисел Фибоначчи на больших числах
{
    Console.WriteLine($"F({i}) = {Fibonacci(i)}");
}
