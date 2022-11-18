int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int number = ReadInt("Введите число: ");
int i = 1;
while(i <= number)
{
    Console.Write(i*i*i + " ");
    i++;
}

