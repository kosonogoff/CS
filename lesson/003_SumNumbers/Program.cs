// сумма двух случайных чисел
int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.Write("Первое случайное число: ");
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100);
Console.Write("Второе случайное число: ");
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.Write("Сумма чисел: ");
Console.WriteLine(result);