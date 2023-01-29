// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

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

int FrequencyDictionary(int[,] matrix, int number)
{
    int count = 0; // здесь будем хранить количество раз, которое встречается элемент

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                count += 1;
            }
        }
    }

    return count;
}

int MinElement(int[,] matrix)
{
    int min = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
            }
        }
    }

    return min;
}

int MaxElement(int[,] matrix)
{
    int max = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max)
            {
                max = matrix[i, j];
            }
        }
    }

    return max;
}

int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
int min = 0;
int max = 9;

int[,] matrixRandom = GetMatrix(rows, columns, min, max);
PrintMatrix(matrixRandom);

Console.WriteLine();
Console.WriteLine($"В нашей исходной матрице встречаются элементы от {MinElement(matrixRandom)} до {MaxElement(matrixRandom)}");

for (int i = MinElement(matrixRandom); i <= MaxElement(matrixRandom); i++)
{
    if (FrequencyDictionary(matrixRandom, i) != 0) Console.WriteLine($"{i} встречается {FrequencyDictionary(matrixRandom, i)} раз");
}