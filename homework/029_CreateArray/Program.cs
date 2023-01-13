// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Данные вводятся с консоли пользователем

int[] CreateNewArray(int size)
{
    int[] arr = new int [size];
    return arr;
}

int size = 8; // здесь прописываем размер массива
int[] array = CreateNewArray(size);

int FillingArray(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int position = 0;

while (position < size)
{
    int number = FillingArray("Введите значение: ");
    array[position] = number;
    position++;
}

Console.WriteLine($"[{string.Join(",", array)}]");