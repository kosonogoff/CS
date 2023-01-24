// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


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

double GetAverage(int[,] matrix, int columns)
{
    double result = 0;
    double count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        result += matrix[i, columns];
        count++;
    }
    return result / count;
}

int rows = new Random().Next(5, 13);
int columns = new Random().Next(5, 13);
int min = -9;
int max = 99;

int[,] matrixRandom = GetMatrix(rows, columns, min, max);
PrintMatrix(matrixRandom);

for (int i = 0; i < columns; i++)
{
    Console.WriteLine($"Среднее арифметическое столбца {i + 1} равно {GetAverage(matrixRandom, i):f1}");
}