// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
// Вывод сделать отдельным методом.

Console.Write("Введите количество элементов массива:  " );
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

for( int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(0,99);
}

void ArrayOutput(int[] array)
{
    int count = array.Length;
    for (int i=0; i< count; i++)
    {
    Console.Write($"{array[i]}"+ " ");
    }
Console.WriteLine();
}

ArrayOutput(array);



