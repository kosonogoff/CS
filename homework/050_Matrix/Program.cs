// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
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

int rows = new Random().Next(5, 13);
int columns = new Random().Next(5, 13);
int min = -9;
int max = 99;

int[,] matrixRandom = GetMatrix(rows, columns, min, max);
PrintMatrix(matrixRandom);

int userRow = ReadNumber("Введите номер строки: ");
int userColumn = ReadNumber("Введите номер столбца: ");

if (userRow > rows || userColumn > columns) Console.WriteLine($"Элемента [{userRow - 1}, {userColumn - 1}] не существует");
else Console.WriteLine($"Данная ячейка содержит значение: {matrixRandom[userRow - 1, userColumn - 1]}");