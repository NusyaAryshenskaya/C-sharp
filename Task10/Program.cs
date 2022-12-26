using static System.Console;

Write("Введите трехзначное число: ");
int N = int.Parse(ReadLine()!);

int Second = (Math.Abs(N) - (Math.Abs(N) / 100) * 100) / 10;
WriteLine("Вторая цифра = {0}", Second );
