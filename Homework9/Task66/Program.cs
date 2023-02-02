using static System.Console;
Clear();

WriteLine("Введите значения двух элементов через пробел: ");
int[] num = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

WriteLine("Сумма натуральных элементов в промежутке заданных чисел: ");
WriteLine(SumNumber(num[0], num[1]));


int SumNumber(int num1, int num2)
{
    return (num1 < num2) ?(num1 == num2 ? num1 : SumNumber(num1, num2 - 1) + num2) 
    : (num1 == num2 ? num1 : SumNumber(num1, num2 + 1) + num2);
}