// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N

int ReadNumber(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int GetProdact(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}

int number = ReadNumber("Введите число: ");
int prodact = GetProdact(number);
Console.WriteLine($"Произведение чисел равно {prodact}");