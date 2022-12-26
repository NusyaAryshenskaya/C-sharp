using static System.Console;

Write("Введите номер дня недели: ");
int Day = int.Parse(ReadLine()!);
WriteLine ("Является ли этот день выходным: ");

if (Day < 6 && Day > 0)
{
    WriteLine("Нет");
    return; 
}

if (Day == 6 || Day == 7)
{
    WriteLine("Да");
    return;
}

if (Day < 1 || Day > 7)
{
    WriteLine("Такого дня недели не существует");
    return;
}
