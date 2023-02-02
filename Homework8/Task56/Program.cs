//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using static System.Console;

Clear();
WriteLine("Введите размер прямоугольной матрицы и диапозон целых значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] matrix = GetMatrix(intParams[0], intParams[1], intParams[2], intParams[3]);
PrintMatrix(matrix);
WriteLine();

WriteLine($"Строка с наименьшей суммой элементов: {GetMinSumRow(matrix)}");

int GetMinSumRow(int[,] Matrix)
{
    int index = 0;
    int[] sumRow = new int[Matrix.GetLength(0)];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            sumRow[i] += Matrix[i, j];
        }
    }
    int minSumRow = sumRow[0];
    for (int i = 1; i < sumRow.Length; i++)
    {
        if (minSumRow > sumRow[i])
        {
            minSumRow = sumRow[i];
            index = i;
        };
    }
    return index;
}


int[,] GetMatrix(int row, int column, int minValue, int maxValue)
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



void PrintMatrix(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Write($"{Matrix[i, j],3} ");
        }
        WriteLine();
    }
}