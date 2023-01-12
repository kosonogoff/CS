// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B

int ReadNumber(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int Degree(int a, int b)
{
    int result = a;
    for (int i = 2; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

int a = ReadNumber("Введите первое число: ");
int b = ReadNumber("Введите второе число: ");
int degree = Degree(a, b);
Console.WriteLine($"{a} в степени {b} будет равно {degree}");