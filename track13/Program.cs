// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число:  " );
int num= Convert.ToInt32(Console.ReadLine());

int controldigit = 3;
int counter = 0;
int a = num;

while(a > 0)
{ 
    a = a / 10;
    counter++;
}
if(counter<3)
 {
 Console.WriteLine("третьей цифры нет");
 }
else
{ 
while(counter > controldigit)
{
    num /= 10;
    counter--;
}

 Console.WriteLine(num%10);
}



