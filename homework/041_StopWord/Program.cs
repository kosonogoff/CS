// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter

int count = 0; // считаем количество положительных чисел
int number = 0; // здесь будем хранить вводимые пользователем числа (с перезаписью)
bool stop = false;

while (stop != true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();

    if (text.ToLower() == "stop" | text.ToLower() == "стоп")
    {
        Console.WriteLine($"Количество введённых положительных чисел равно: {count}");
        stop = true;
    }

    else if (text == "")
    {
        Console.Write("Повторите ввод. ");
    }

    else
    {
        number = Convert.ToInt32 (text);
        if (number > 0)
        {
            count = count + 1;
        }
    }
}