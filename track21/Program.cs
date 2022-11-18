int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Введите координату x точки А: ");
int y1 = ReadInt("Введите координату y точки А: ");
int z1 = ReadInt("Введите координату z точки А: ");
int x2 = ReadInt("Введите координату x точки B: ");
int y2 = ReadInt("Введите координату x точки B: ");
int z2 = ReadInt("Введите координату z точки B: ");


int x = x2-x1;
int y = y2-y1;
int z = z2-z1;
int dist = (x*x + y*y + z*z);
double length = Math.Sqrt(dist);
Console.WriteLine(length);
