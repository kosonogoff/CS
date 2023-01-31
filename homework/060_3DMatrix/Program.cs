// Сформируйте трёхмерный массив из неповторяющихся(?) двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Get3DMatrix(int x, int y, int z)
{
    int[,,] matrix = new int[x, y, z];
    int[] numbers = new int[x * y * z]; // здесь будем хранить значения сгенерированных чисел
    int indexRandomNumber = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int getNewNumber = new Random().Next(10, 100); // числа 10-99

                bool result = true; // проверяем число на уникальность
                while (result == false)
                {
                    for (int p = 0; p < numbers.Length; p++)
                    {
                        if (numbers[p] == getNewNumber)
                        {
                            result = true;
                            break;
                        }

                        else if (p == numbers.Length - 1) result = false;
                    }
                    getNewNumber = new Random().Next(10, 100);
                }

                matrix[i, j, k] = getNewNumber;
                numbers[indexRandomNumber] = getNewNumber;
                indexRandomNumber++;
            }
        }
    }
    // Console.WriteLine($"Значения: [{string.Join(", ", numbers)}]"); // проверка сгенерированных цисел
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}[{i},{j},{k}]; ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = Get3DMatrix(2, 2, 2);
Print3DMatrix(matrix);