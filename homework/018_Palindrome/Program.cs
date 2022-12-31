// Напишите программу, которая принимает на вход ЦЕЛОЕ пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Это не пятизначное число");
    return;
}

int digit5 = number % 10;
int digit4 = (number / 10) % 10;
int digit3 = (number / 100) % 10;
int digit2 = (number / 1000) % 10;
int digit1 = number / 10000;

if (digit5 == digit1 && digit4 == digit2)
{
    Console.WriteLine("Данное число является палиндромом");
}

else
{
    Console.WriteLine("Данное число не является палиндромом");
}