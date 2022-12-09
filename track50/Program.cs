// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Random rnd = new Random();

FillArray(array);
Console.WriteLine();
PrintArray(array);

Console.WriteLine("задайте значение строки искомого элемента:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("задайте значение столбца искомого элемента:");
int column = Convert.ToInt32(Console.ReadLine());


if (row>=0 && row<=m && column>=0 && column<=n )
    { 
        Console.Write($"{array[row, column]} ");
    }
else
{
Console.WriteLine(" Такого элемента нет");
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


// bool foundFlag = false;

// for (int i = 0; i < m; i++)
//  {
//     for (int j = 0; j < n; j++)
//         if (array[i,j] == number)
//         {
//             Console.WriteLine("Позиция искомого элемента = " + i + j );
//             foundFlag = true;
//         }
    

//  }
