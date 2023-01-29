// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. (Транспонирование)

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

int[,] NewMatrix(int[,] matrix)
{
    int rowsNew = matrix.GetLength(1); // в новой матрице rows = columns считываемой матрицы
    int columnsNew = matrix.GetLength(0); // в новой матрице columns = rows считываемой матрицы
    int[,] matrixNew = new int[rowsNew, columnsNew];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixNew[j, i] = matrix[i, j];
        }
    }

    return matrixNew;
}

int rows = new Random().Next(5, 13);
int columns = new Random().Next(5, 13);
int min = -9;
int max = 99;

int[,] matrixRandom = GetMatrix(rows, columns, min, max);
PrintMatrix(matrixRandom);

int[,] matrixNew = NewMatrix(matrixRandom);
Console.WriteLine();
PrintMatrix(matrixNew);