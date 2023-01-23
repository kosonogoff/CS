// Задайте двумерный массив размером m×n, заполненный случайными целыми числами
// m = 3, n = 4.

int[,] GetMatrix (int rows, int columns, int min, int max)
{
    int[,] matrix = new int [rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "; ");
        }
        Console.WriteLine();
    }
}

const int rows = 3;
const int columns = 4;
int min = -100;
int max = 100;

int[,] array = GetMatrix (rows, columns, min, max);
PrintMatrix(array);