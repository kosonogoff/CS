// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            if (matrix[i, k] > -1 && matrix[i, k] < 10) Console.Write(" " + matrix[i, k] + " ");
            else Console.Write(matrix[i, k] + " ");
        }
        Console.WriteLine();
    }
}

void RewriteRows(int[,] matrix)
{
    int rowFinish = matrix.GetLength(0) - 1; // индекс начинается с 0, а не с 1

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[rowFinish, i];
        matrix[rowFinish, i] = temp;
    }
}

int rows = new Random().Next(5, 13);
int columns = new Random().Next(5, 13);
int min = -9;
int max = 99;

int[,] matrixRandom = GetMatrix(rows, columns, min, max);
PrintMatrix(matrixRandom);

Console.WriteLine();
RewriteRows(matrixRandom);
PrintMatrix(matrixRandom);