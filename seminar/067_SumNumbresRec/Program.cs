// Напишите программу, которая будет принимать на вход ЦЕЛОЕ число 
// и возвращать сумму его цифр

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumRec(int number)
{
    if (number < 10) return number;
    return (number % 10) + GetSumRec(number / 10);
}

int number = ReadNumber("Введите число: ");
Console.Write($"Сумма цифр в числе равна: {GetSumRec(number)}");