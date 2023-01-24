// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double[,] GetMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(min, max)) / 100; 
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double number = matrix[i, j];
            // для красоты вывода на экран добавим пробел перед положительными числами
            if(number >= 0) Console.Write($" {number:f2} "); 
            else Console.Write($"{number:f2} ");
        }
        Console.WriteLine();
    }
}

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = ReadNumber("Введите количечство строк в матрице: ");
int columns = ReadNumber("Введите количество столбцов в матрице: ");
int min = -1000;
int max = 1000;

double[,] array = GetMatrix(rows, columns, min, max);
PrintMatrix(array);