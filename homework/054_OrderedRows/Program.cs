// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void OrderedRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) /// ???
        {
            int max = matrix[i, j];
            int indexMax = j + 0;
            int index = j + 1;

            while (index < matrix.GetLength(1))
            {
                if (matrix[i, index] > max)
                {
                    max = matrix[i, index];
                    indexMax = index;
                }
                index++;
            }

            int temp = matrix[i, j];
            matrix[i, j] = max;
            matrix[i, indexMax] = temp;
        }
    }
}

int rows = new Random().Next(5, 10);
int columns = new Random().Next(10, 20);
int min = -9;
int max = 99;

int[,] matrixRandom = GetMatrix(rows, columns, min, max);
PrintMatrix(matrixRandom);
Console.WriteLine();

OrderedRows(matrixRandom);
PrintMatrix(matrixRandom);