// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbersUpRec(int n)
{
    if (n == 0) return;
    PrintNumbersUpRec(n - 1);
    Console.Write(n + " ");
}

int number = ReadNumber("Введите число: ");
PrintNumbersUpRec(number);