// Напишите программу, которая принимает на вход ЦЕЛОЕ число
// и выдаёт количество цифр в числе.

int ReadNumber(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int NumberLength(int number)
{
    int length = 0;
    while (number != 0)
    {
        number = number / 10;
        length = length + 1;
    }
    return length;
}

int number = ReadNumber("Введите число: ");
int length = NumberLength(number);
Console.Write($"В числе {number} количеcтво цифр равно {length}");