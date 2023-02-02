using static System.Console;

Clear();
WriteLine("Введите N: ");
int N = int.Parse(ReadLine()!);
PrintNumbers(N, 1);

void PrintNumbers(int num1, int num2)
{
    if (num1 == num2) Write(num1);
    else
    {
        PrintNumbers(num1, num2 + 1);
        Write($",{num2}");
    }
}