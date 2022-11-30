// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write(" Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

double min = -99;
double max = 99;

FillArrayRandomNumbers(numbers, min, max);
WriteArray(numbers);

void FillArrayRandomNumbers( double[] array, double min, double max)
{
    Random x = new Random();
for (int i =0; i < array.Length; i++ )
{
    array[i] = Convert.ToDouble(x.Next(-100, 100) / 10.0);
}
}

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double minim = numbers[0];
double maxim = numbers[0];
double dif = 0;

for (int i = 1; i < numbers.Length; i ++)

{
    if (numbers[i]< minim)
{    
    minim = numbers[i];
}
if (numbers[i] > maxim)
{
    maxim = numbers[i];
     }
}
dif = maxim - minim;

Console.WriteLine("Разница между максимальным и минимальным элементами массива:" + dif );




