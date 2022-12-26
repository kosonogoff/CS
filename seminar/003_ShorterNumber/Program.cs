// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);

Console.WriteLine($"Случайное число: {number}");

int firstDigit = number / 100;
int thirdDigit = number % 10;
int numberNew = firstDigit * 10 + thirdDigit;

Console.WriteLine($"Новое число: {numberNew}");