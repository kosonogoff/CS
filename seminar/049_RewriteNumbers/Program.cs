//  Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int number = matrix[i, j];
            if (number < 10) Console.Write("0" + matrix[i, j] + " ");
            // для чисел 1-9 добавляем 0 впереди, чтобы было визуально приятнее
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void RewriteNumbersInMatrix(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

int rows = 4;
int columns = 4;
int min = 1;
int max = 9;

int[,] array = GetMatrix(rows, columns, min, max);
PrintMatrix(array);
RewriteNumbersInMatrix(array);
Console.WriteLine();
PrintMatrix(array);