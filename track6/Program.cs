//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).

Console.Write("Введите число:  " );
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 ==1)
{
 Console.WriteLine( " Число  "  + num + " нечетное");
}
else
{
Console.WriteLine( " Число  "  + num + " четное");
}
