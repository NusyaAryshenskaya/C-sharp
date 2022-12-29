using static System.Console;
Clear();

WriteLine("Введите число N:");
int N = int.Parse(ReadLine()!);

WriteLine("Числа от 1 до N в третьей степени:");

if (N > 0)
{
    int index = 1;
    while (index <= N)
    {
        Write($"{Math.Pow(index, 3)} ");
        index += 1;
    }
    WriteLine(" ");
}
else
{
    int index = 1;
    while (index >= N)
    {
        Write($"{Math.Pow(index, 3)} ");
        index -= 1;
    }
    WriteLine(" ");
}