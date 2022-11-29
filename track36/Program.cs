// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write(" Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, -99, 99);
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
}

int sum = 0;
for (int i = 1; i < numbers.Length; i +=2)
    {
        sum += numbers[i];
    }

Console.WriteLine("Сумма элементов массива, стоящих на нечетных позициях: " + sum);


