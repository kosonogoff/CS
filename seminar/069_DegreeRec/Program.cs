// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит ЦЕЛОЕ число А в целую степень B с помощью рекурсии.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int DegreeNumberRec(int number, int degree)
{
    if (degree == 1) return number;
    return number * DegreeNumberRec(number, degree - 1);
}

int number = ReadNumber("Введите число: ");
int degree = ReadNumber("Введите степень, в которую нужно возвести число: ");
Console.WriteLine($"{number} в степени {degree} равно: {DegreeNumberRec(number, degree)}");