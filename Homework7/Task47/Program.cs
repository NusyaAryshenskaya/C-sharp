using static System.Console;

Clear();
WriteLine("Введите размер матрицы и диапозон значений через пробел: ");
int[] parametr = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

double[,] array = GetMatrixArray(parametr[0], parametr[1], parametr[2], parametr[3]);
PrintMatrixArray(array);



double[,] GetMatrixArray(int rows, int columns, double minValue, int maxValue)
{
    Random rnd = new Random();
    double[,] resultArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = minValue + rnd.NextDouble() * ((maxValue - minValue));
        }
    }
    return resultArray;
}


void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5:f1} ");
        }
        WriteLine();
    }
}