// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

string input;
string stop = "exit";

do
{
    Console.WriteLine("Введите стоп слово:");
    input = Console.ReadLine();
}
while (input != stop);
