// В переменной string есть секретное сообщение, во второй есть пароль. 
// Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.

string password = "simsim";
string input;
string secretText = "Аллилуйя";

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Введите пароль:");
    input = Console.ReadLine();
    if (input == password)
    {
        Console.WriteLine(secretText);
        break;
    }
}



