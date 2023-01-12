// Напишите программу, которая на вход принимает ЦЕЛОЕ число "А"
// и находит сумму всех чисел от 1 до "А"

int ReadNumber(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int GetSum1ToA(int a)
{
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        sum = sum + i; // sum +- i;
    }
    return sum;
}

int number = ReadNumber("Введите число: ");

if(number > 0)
{
    int sum = GetSum1ToA(number);
    Console.Write($"Сумма чисел от 1 до {number} равна {sum}");
}

else
{
    Console.Write("Введено неверное значение. Число должно быть больше нуля");
}