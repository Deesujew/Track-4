﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели:  " );
int num= Convert.ToInt32(Console.ReadLine());

if(num == 6 || num ==7)
{
    Console.WriteLine("выходной" );
}
if (num>=1 && num<=5 )
{
   Console.WriteLine("будний");  
}