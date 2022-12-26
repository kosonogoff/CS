// Напишите программу, которая принимает на вход ЦЕЛОЕ число
// и проверяет, кратно ли оно одновременно 7 и 23

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int div1 = number % 7;
int div2 = number % 23;

if (div1 == 0) // if (number % 7 == 0 && number % 23 == 0) вместо 10-12 строк
{
    if (div2 == 0)
    {
        Console.WriteLine("Да, число кратно 7 и 23");
    }

    else
    {
    Console.WriteLine("Нет, число не кратно 7 и 23");
    }
}

else
{
    Console.WriteLine("Нет, число не кратно 7 и 23");
}