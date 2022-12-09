// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Random rnd = new Random();

FillArray(array);
Console.WriteLine();
PrintArray(array);



double avrg = 0.0;

for (int j = 0; j < n; j++)
 {
    for (int i = 0; i < m; i++)
        {
            avrg += array[i,j];
             
        }
Console.WriteLine(avrg/m);
avrg = 0.0;
 }



void FillArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToInt32(rnd.Next(-20, 20));}}}


void PrintArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}
