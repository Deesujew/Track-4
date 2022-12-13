// Напишите программу, которая заполнит спирально массив 4 на 4. 

int n = 4;
int[,] array = new int[n, n];

// Console.WriteLine("Задайте количество строк и столбцов двумерного массива:");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[n, n];
int t = 1;
int i = 0;
int j = 0;

while (t <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = t;
  t++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(array);

void PrintArray(int[,] matr)
    {
        for (int i = 0; i < n; i++)
            { 
                for (int j = 0; j < n; j++)
                    {
                         Console.Write($"{matr[i, j]} ");
                    }
                            Console.WriteLine();
            }
    }