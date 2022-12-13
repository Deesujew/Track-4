// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Задайте количество строк трехмерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов трехмерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество строк трехмерного массива:");
int k = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[m, n, k];
Random rnd = new Random();

FillArray(array);
Console.WriteLine();
PrintArray(array);

void FillArray(int[,,] matr)
{ 
    int t = Convert.ToInt32(rnd.Next(10, 40));
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        { 
            for (int z=0; z < k; z++)
            { 
            
                matr[i,j,z] = ++t;
                
            }
        }
    }
}



void PrintArray(int[,,] matr)
{ 
    for (int z = 0; z < k; z++)
    { 
        for (int i = 0; i < m; i++)
        { 
           
 
            for (int j = 0; j < n; j++)
            { 
                
                Console.Write($"{matr[i, j, z]}"+(i,j,z));
               
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
