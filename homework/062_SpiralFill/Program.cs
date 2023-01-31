// Напишите программу, которая заполнит спирально массив 4 на 4.

void SpiralFill(int[,] matrix, int rows, int columns)
{
    int n = rows, m = columns, c = 0, i = 0, j = 0, k = 0;

    while (k < rows * columns)
    {
        for (j = c; j < m; j++)
        {
            if (k == rows * columns) break;
            matrix[i, j] = k;
            k++;
        }
        j--;
        
        for (i = c + 1; i < n; i++)
        {
            if (k == rows * columns) break;
            matrix[i, j] = k;
            k++;
        }
        i--;
        
        for (j = m - 2; j >= c; j--)
        {
            if (k == rows * columns) break;
            matrix[i, j] = k;
            k++;
        }
        j++;
        
        for (i = n - 2; i >= c + 1; i--)
        {
            if (k == rows * columns) break;
            matrix[i, j] = k;
            k++;
        }
        
        c++;
        n--;
        m--;
        i = c;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            if (matrix[i, k] < 10) Console.Write("0" + matrix[i, k] + " ");
            else Console.Write(matrix[i, k] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];
SpiralFill(matrix, 4, 4);
PrintMatrix(matrix);