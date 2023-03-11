// Написать решение уравнения линейного типа
// a*m + b*n = c
// Задача на передачу денежных средств

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int PrintIndex(int[]array, int index)
{
    return array[index];
}

/*
int[] Eukleides(int[] array)
{
    int[] matrix = new int[10];



    return martix;
}
*/

int a = ReadNumber("Введите размер первой купюры: ");
int b = ReadNumber("Введите размер второй купюры: ");
int sum = ReadNumber("Введите размер суммы, которую нужно передать: ");

int[] input = new int[3] { a, b, sum };

Console.Write($"Нужно решить уравнение типа {PrintIndex(input, 0)}m + {PrintIndex(input, 1)}n = {PrintIndex(input, 2)}");

// a * x + b * y = 1

// m = x + b * t
// n = y - a * t