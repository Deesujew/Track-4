//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число:  " );
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:  " );
int num2 = Convert.ToInt32(Console.ReadLine());

if(num2>num1)
{
 Console.WriteLine( " Большее число - " + num2 + " Меньшее число -" + num1);
}
else
{
Console.WriteLine( " Большее число - " + num1 + " Меньшее число -" + num2);
}
