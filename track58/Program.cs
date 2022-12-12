// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[m, n];
int[,] array2 = new int[m, n];
Random rnd = new Random();

FillArray(array1);
Console.WriteLine();
PrintArray(array1);

FillArray(array2);
Console.WriteLine();
PrintArray(array2);

int[,] mltpArray = new int [m,n];

for (int i = 0; i < m; i++)
 { 
    for (int j = 0; j < n; j++)
        { 
            mltpArray[i,j] = array1[i,j] * array2[i,j];
        }
 }

PrintArray(mltpArray);



void FillArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToInt32(rnd.Next(-20, 20));}}}


void PrintArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}
