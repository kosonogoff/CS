// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

int[,] Multiplication(int[,] one, int[,] two) /// НЕ РАБОТАЕТ!!!
{
    int[,] multi = new int[one.GetLength(0), two.GetLength(1)];

    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < one.GetLength(1); k++)
            {
                sum = sum + (one[i, k] * two[k, i]);
            }
            
            multi[i, j] = sum;
        }
    }

    return multi;
}

int[,] matrixOne = GetMatrix(3, 4, 0, 10);
Console.WriteLine("Матрица №1");
PrintMatrix(matrixOne);
Console.WriteLine();

int[,] matrixTwo = GetMatrix(4, 3, -1, 5);
Console.WriteLine("Матрица №2");
PrintMatrix(matrixTwo);
Console.WriteLine();

int[,] matrixMult = Multiplication(matrixOne, matrixTwo);
Console.WriteLine("Произведение двух матриц");
PrintMatrix(matrixMult);