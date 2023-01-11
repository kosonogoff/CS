// Дан текст. В тексте нужно заменить все пробелы черточками,
// маленькие "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "— Скажи-ка, дядя, ведь недаром"
            + " Москва, спаленная пожаром,"
            + " Французу отдана?"
            + " Ведь были ж схватки боевые,"
            + " Да, говорят, еще какие!"
            + " Недаром помнит вся Россия"
            + " Про день Бородина!";

// string s = "qwerty"
//             012345
// s[3] значит "r"

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // инициализация пустой строки

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '_');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');
Console.WriteLine();
Console.WriteLine(newText);
Console.WriteLine();