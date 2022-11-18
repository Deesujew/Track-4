//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число:  " );
int num = Convert.ToInt32(Console.ReadLine());

int a = num / 10000;
int b = num / 1000 % 10;
int g = num / 10 % 10;
int d = num % 10;

if( a == d && b == g)
{
    Console.WriteLine(" палиндром");
}
else 
{
    Console.WriteLine("не палиндром");
}

