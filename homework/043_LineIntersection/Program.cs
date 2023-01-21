// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadСoordinates (string message, string coordinates)
{
Console.Write($"{message} {coordinates}: ");
return Convert.ToDouble(Console.ReadLine());
}

double[] PointOfIntersection (double c, double a, double d, double b)
{
    // две прямые имеют уравнения y = a*x+c и y = b*x+d, 
    // где a и b — угловые коэффициенты прямых, а c и d — пересечения прямых с осью y

    double[] point = new double[2]; // здесь будем хранить координаты точки пересечения
    point[0] = (d - c) / (a - b); // координата X
    point[1] = a * point[0] + c; // координата Y
    return point;
}

double b1 = ReadСoordinates ("Enter a value for the coordinate", "b1");
double k1 = ReadСoordinates ("Enter a value for the coordinate", "k1");
double b2 = ReadСoordinates ("Enter a value for the coordinate", "b2");
double k2 = ReadСoordinates ("Enter a value for the coordinate", "k2");

if (k1 == k2) // пропишем условие для параллельных линий
{
    Console.WriteLine($"Lines don't cross");
}

else
{
    double[] point = PointOfIntersection (b1, k1, b2, k2);
    // Console.WriteLine ($"The point of lines intersection: ({string.Join("; ", point)})");
    Console.Write ("The point of lines intersection: (");
    Console.Write ($"{point[0]:f4}; "); // выводим координату X
    Console.Write ($"{point[1]:f4})"); // выводим координату Y
}