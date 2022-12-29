using static System.Console;

Write("Введите число: ");

long number = long.Parse(ReadLine()!);
long rev = 0;
long number2 = number;
while (number2 != 0)
{
    rev *= 10;
    rev += number2 % 10;
    number2 = number2 / 10;
}
Write("Данное число является палиндромом: ");
Write(rev == number ? "Да" : "Нет");
