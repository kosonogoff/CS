// Задайте двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

void GetRowMinSum(int[,] matrix) // выводим на экран строки с наименьшей суммой
{
    int[] counter = new int[matrix.GetLength(0)]; // создадим массив для хранения значений суммы строк

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }

        counter[i] = sum;
    }
    
    // Console.WriteLine($"Суммы строк: [{string.Join(", ", counter)}]"); // проверка подсчета суммы элементов
    
    int minSum = counter[0];
    for (int i = 0; i < counter.Length; i++)
    {
        if (counter[i] < minSum) 
        {
            minSum = counter[i];
        }
    }

    Console.Write("Индекс строк(и) с наименьшей суммой элементов: ");

    for (int i = 0; i < counter.Length; i++)
    {
        if (counter[i] == minSum) 
        {
            Console.Write($"[{i}] ");
        }
    }
}

int rows = new Random().Next(3, 10); // количество строк в матрице
int columns = new Random().Next(3, 5);
int min = 0;
int max = 9;

int[,] matrixRandom = GetMatrix(rows, columns, min, max);
PrintMatrix(matrixRandom);
Console.WriteLine();
GetRowMinSum(matrixRandom);