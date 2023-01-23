// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Доп. условие для 51 задачи: сделать суммирование в один цикл. 
// Матрица может быть прямоугольной

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
            if (number < 10 && number >= 0) Console.Write("0" + matrix[i, j] + " ");
            // для чисел 0-9 добавляем 0 впереди, чтобы было визуально приятнее
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int GetSum(int[,] matrix)
{
    int result = 0;

    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        result += matrix[i, i];
    }
    // for (int i = 0; i < matrix.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matrix.GetLength(1); j++)
    //     {
    //         if (i == j) result += matrix[i, j];
    //     }
    // }
    return result;
}

int rows = new Random().Next(5, 20);
int columns = new Random().Next(5, 20);
int min = 0;
int max = 9;
int result = 0; // здесь будем хранить результат работы программы

int[,] array = GetMatrix(rows, columns, min, max);
PrintMatrix(array);
result = GetSum(array);
Console.WriteLine($"sum = {result}");