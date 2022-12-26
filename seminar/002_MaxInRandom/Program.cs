// Напишите программу, которая выводит случайное ЦЕЛОЕ число
// из отрезка [10, 99] и показывает наибольшую цифру числа

int number = new Random().Next(10, 100); // Random number 10-99

int firstDigit = number / 10;
int secondDigit = number % 10; // остаток от целочисленного деления

Console.WriteLine($"Случайное число: {number}");

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа: {firstDigit}");
}

if (secondDigit > firstDigit)
{
    Console.WriteLine($"Наибольшая цифра числа: {secondDigit}");
}

if (firstDigit == secondDigit)
{
    Console.WriteLine($"Цифры в числе равны");
}