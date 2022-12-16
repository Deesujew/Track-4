// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int num1 = ReadInt("Введите число M: ");
//int num2 = ReadInt("Введитt число N: ");
//Console.WriteLine(NaturalNumber(num1));
NaturalNumber(num1);

int NaturalNumber(int n)
{
    Console.Write(n +", ");
    if (n == 1)
        return 0;
    else
    {
        return NaturalNumber(n-1);
    }
}


int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
