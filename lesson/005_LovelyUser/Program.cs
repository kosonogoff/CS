Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "паша")
{
    Console.WriteLine("Приветствую тебя, Мой Господин!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}