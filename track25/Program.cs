// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите первое число:  " );
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:  " );
int num2 = Convert.ToInt32(Console.ReadLine());

int digit = 1; 

for ( int i=0; i < num2; i++)
{
    digit *= num1;
}


Console.WriteLine( digit );
