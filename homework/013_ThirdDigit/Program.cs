// Напишите программу, которая выводит третью цифру заданного ЦЕЛОГО числа 
// или сообщает, что третьей цифры нет.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = -number;
}

if (number < 100)
{
    Console.WriteLine($"В данном числе нет третьей цифры");
}

else if (number >= 100 && number <= 999)
{
    int ThirdDigit = number % 10;
    Console.WriteLine($"Третья цифра заданного числа {ThirdDigit}");
}

else if (number >= 1000)
{
    
    int result = number / 10;
    
    while (result >= 9999)
    {
        result = result / 10;
    }
    
    int ThirdDigit = result % 10;
    Console.WriteLine($"Третья цифра заданного числа {ThirdDigit}");
}
