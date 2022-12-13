// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Random rnd = new Random();
int t = 0;


FillArray(array);
Console.WriteLine();
PrintArray(array);


for (int i = 0; i < m; i++)
 { 

    for (int j = 0; j < n; j++)
        { 
        int maxnum = array[i,j];
        int maxind = j;
          for (int k = j + 1; k < m; k++)
          {
            if (maxnum < array[i,k])
            {
                maxnum = array[i,k];
                maxind=k;

            }
          }
          if (maxind != j)
          { t = array[i,j];
            array[i,j]=array[i,maxind];
            array[i,maxind]=t;
          }
        }
 }


 PrintArray(array);


void FillArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToInt32(rnd.Next(0, 10));}}}


void PrintArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}
