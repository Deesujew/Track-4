// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


Console.Write(" Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, -999, 999);
WriteArray(numbers);

void FillArrayRandomNumbers( int[] array, int min, int max)
{
for (int i =0; i < array.Length; i++ )
{
    array[i] = new Random().Next(min, max);

}
}

void WriteArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write(array[i] + " ");

    }
    // Console.Write(array[i] + " ");
}

int count = 0;
for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count +=1;
            ;
            
        }
  
    }

Console.WriteLine("Число четных элементов массива: " + count);

