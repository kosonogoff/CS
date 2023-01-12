// Напишите программу, которая принимает на вход ЦЕЛОЕ число 
// и выдаёт сумму цифр в числе

int ReadNumber(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int SumInTotal(int a)
{
    int result = 0;
    while (a != 0)
    {
        int remainder = a % 10;
        result = result + remainder;
        a = a / 10;        
    }
    return result;
}

int number = ReadNumber("Введите число: ");

if(number > 0)
{
    int sum = SumInTotal(number);
    Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
}

else if(number == 0)
{
    Console.WriteLine($"Это же ноль. Здесь всё очевидно!");
}

else if(number < 0)
{
    int sum = SumInTotal(-number);
    Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
}