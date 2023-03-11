// Написать решение уравнения линейного типа
// a*m + b*n = c
// Задача на передачу денежных средств

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int PrintNumInArr(int[] array, int index)
{
    return array[index];
}

int[,] Eukleides(int[] array)
{
    int[,] matrix = new int[2, 5];
    /*
    в первой строке будем хранить значения для m
    во второй строке будем хранить значения для n
    максимум будем хранить по 5 значений
    нужно решить уравнения
    a * x + b * y = 1
    m = x + b * t
    n = y - a * t,
    где значения t прописываем в массив
    */

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == 0) Console.Write("m: ");
        else Console.Write("n: ");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int number = matrix[i, j];
            // для красоты вывода на экран добавим пробел перед положительными числами
            if (number >= 0) Console.Write($" [{number}] ");
            else Console.Write($"[{number}] ");
        }
        Console.WriteLine();
    }
}

int a = ReadNumber("Введите размер первой купюры: ");
int b = ReadNumber("Введите размер второй купюры: ");
int sum = ReadNumber("Введите размер суммы, которую нужно передать: ");

int[] input = new int[3] { a, b, sum };

Console.Write($"Нужно решить уравнение типа {PrintNumInArr(input, 0)}m + {PrintNumInArr(input, 1)}n = {PrintNumInArr(input, 2)}");

int[,] result = Eukleides(input);

Console.WriteLine(", где m и n имеют следующие значения");
PrintMatrix(result);