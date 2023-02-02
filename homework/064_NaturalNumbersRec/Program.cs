// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// от большего к меньшему

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumberDownRec(int number, int finish = 1)
{
    if (finish > number) return;
    PrintNumberDownRec(number, finish + 1);
    Console.Write(finish + " ");
}

int number = ReadNumber("Введите число: ");
PrintNumberDownRec(number);