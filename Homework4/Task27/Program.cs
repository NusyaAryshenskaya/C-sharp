using static System.Console;
Clear();


Write("Введи число: ");
int number = int.Parse(ReadLine()!);

WriteLine(sum(number));


int sum (int number)
{
    number = Math.Abs(number);
    int result = 0;
    
    while(number > 0)
    {
        result += number%10;
        number /= 10;
    }

    return result;
}
