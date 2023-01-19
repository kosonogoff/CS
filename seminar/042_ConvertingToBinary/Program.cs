// Напишите программу, которая будет преобразовывать десятичное число в двоичное

int ReadNumber(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

string ConvertingToBinary(int decimalNumber)
{
    var binaryNumber = string.Empty;
    while (decimalNumber > 0)
    {
        binaryNumber = (decimalNumber % 2) + binaryNumber;
        decimalNumber /= 2; // decimalNumber = decimalNumber / 2;
    }
    return binaryNumber;
}

int number = ReadNumber("Введите число: ");
var binary = ConvertingToBinary(number);
Console.WriteLine($"{number} в двоичной системе выглядит как {binary}");