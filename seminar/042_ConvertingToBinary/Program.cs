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

void PrintBinaryRec(int n)
{
    if (n <= 0) return; // (!)сразу прописываем выход из рекурсии
    PrintBinaryRec(n / 2); // рекурсивный вызов
    Console.Write(n % 2);
}

int number = ReadNumber("Введите число: ");
var binary = ConvertingToBinary(number);
// Console.WriteLine($"Число {number} в двоичной системе выглядит как {binary}");

Console.Write($"Число {number} в двоичной системе выглядит как: ");
PrintBinaryRec(number);