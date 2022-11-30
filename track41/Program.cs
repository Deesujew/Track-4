// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через запятую:");
string output = Console.ReadLine();
char separator = ',';
String[] result = output.Split(separator);
int count = 0;
int[] array = new int[result.Length];
        for (int i = 0; i < result.Length; i++) 
        {
        array[i]=Convert.ToInt32(result[i]);
          //Console.WriteLine(array[i]);
          if (array[i]>0)
        {
            count++;
        }
        }

Console.WriteLine("Чисел больше 0 - " + count);

