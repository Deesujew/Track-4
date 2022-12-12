// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов. Например, задан массив:

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Random rnd = new Random();

FillArray(array);
Console.WriteLine();
PrintArray(array);

int minrow =0 ;
int minsum = int.MaxValue;


for (int i = 0; i < m; i++)
 { 
    int sum = 0;
    for (int j = 0; j < n; j++)
        { 
            sum += array[i,j];
        }
        if ( sum < minsum )
        {
            minsum = sum;
            minrow = i;
        }
 }

Console.WriteLine(" Номер строки с наименьшей суммой элементов - " + minrow );



void FillArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToInt32(rnd.Next(-20, 20));}}}


void PrintArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}
