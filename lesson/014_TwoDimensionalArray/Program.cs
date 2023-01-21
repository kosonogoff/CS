// ДВУМЕРНЫЕ (МНОГОМЕРНЫЕ) МАССИВЫ

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    // matr.GetLength(0) возвращает количество строк в массиве
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        // matr.GetLength(1) возвращает количество столбцов в массиве
        {
            Console.Write($"{matr[i, j]} ");
        }

        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(10,100);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine(); // добавим пустую строку для красоты
PrintArray(matrix);