using static System.Console;

Write("Введите число: ");
int N = int.Parse(ReadLine()!);

if (Math.Abs(N) < 100)
{
    WriteLine("В номере третьей цифры нет", N);
    return; 
}

int Digit3 = (Math.Abs(N) - (Math.Abs(N) / 1000) * 1000) / 100;
WriteLine("Третья цифра числа {0} равна: {1}", N, Digit3);

return; 