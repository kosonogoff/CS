// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumRec(int a, int b)
{
    if (a == b) return a;
    return a + GetSumRec(a + 1, b);
}

int min = ReadNumber("Введите число: ");
int max = ReadNumber("Введите число: ");

if (min == max) Console.WriteLine("Числа равны!");

else if (min > max)
{
    int temp = max;
    max = min;
    min = temp;
    Console.WriteLine($"Сумма элементов от {min} до {max} равна {GetSumRec(min, max)}");
}

else
{
    Console.WriteLine($"Сумма элементов от {min} до {max} равна {GetSumRec(min, max)}");
}