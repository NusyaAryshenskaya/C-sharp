using static System.Console;

Clear();
WriteLine("Введите размер матрицы и диапозон значений через пробел: ");
int[] parameter = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = GetMatrixArray(parameter[0], parameter[1], parameter[2], parameter[3]);
PrintMatrixArray(array);

WriteLine("Среднее арифметическое каждого столбца: ");
WriteLine($"[{string.Join("   ", GetAverage(array))}]");

double[] GetAverage(int[,] Array)
{
    double[] result = new double[Array.GetLength(1)];

    for (int i = 0; i < Array.GetLength(1); i++)
    {
        int j = 0;
        for (; j < Array.GetLength(0); j++)
        {
            result[i] += Array[j, i];
        }
        result[i] = Math.Round((result[i] / j), 1);
    }

    return result;
}


int[,] GetMatrixArray(int row, int column, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return result;
}



void PrintMatrixArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Write($"{Array[i, j],3} ");
        }
        WriteLine();
    }
}