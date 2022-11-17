//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число:  " );
int N = Convert.ToInt32(Console.ReadLine());

int digit = 1;

while (digit < N)

if(digit % 2 ==1)
{
 digit++;
}
else
{
Console.WriteLine( digit  +  " ");   
digit++;
}
