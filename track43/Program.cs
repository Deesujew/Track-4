// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// Привет Виталию!!!
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double  k1 = ReadDouble("Введите коэффициент k1: ");
double  b1 = ReadDouble("Введите коэффициент b1: ");
double  k2 = ReadDouble("Введите коэффициент k2: ");
double  b2 = ReadDouble("Введите коэффициент b2: ");

if (k1 == k2)
{
    Console.WriteLine(" Прямые не пересекутся в этой плоскости ");
}
else
{
double x = (b2-b1)/(k1-k2);
double y = k1 *x + b1;

Console.WriteLine(x + "," + y);
}


double ReadDouble(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
