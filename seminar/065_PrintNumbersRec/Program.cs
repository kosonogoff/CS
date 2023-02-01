// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumRec(int min, int max)
{
    if (max == min - 1) return;
    PrintNumRec(min, max - 1);
    Console.Write(max + " ");
}

int min = ReadNumber("Введите число: ");
int max = ReadNumber("Введите число: ");

if (min == max) Console.WriteLine("Эти числа равны!");

else if (min > max)
{
    int temp = max;
    max = min;
    min = temp;
    PrintNumRec(min, max);
}

else PrintNumRec(min, max);