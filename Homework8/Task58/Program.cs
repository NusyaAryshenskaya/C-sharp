//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using static System.Console;

Clear();
WriteLine("Введите размер первой матрицы и диапозон значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] matrix = GetMatrix(intParams[0], intParams[1], intParams[2], intParams[3]);

WriteLine("Введите размер второй матрицы и диапозон значений через пробел: ");
int[] intParams1 = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] matrix1 = GetMatrix(intParams1[0], intParams1[1], intParams1[2], intParams1[3]);


PrintMatrix(matrix);
WriteLine();
PrintMatrix(matrix1);
WriteLine();
if (matrix.GetLength(1) != matrix1.GetLength(0))
    WriteLine("Эти матрицы нельзя умножить на друг друга!");
else
    PrintMatrix(MultMatrix(matrix, matrix1));




int[,] MultMatrix(int[,] Matrix1, int[,] Matrix2)
{

    int[,] result = new int[Matrix1.GetLength(0), Matrix2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix1.GetLength(1); k++)
                result[i, j] += Matrix1[i, k] * Matrix2[k, j];
        }
    }

    return result;
}


int[,] GetMatrix(int row, int column, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultMatrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            resultMatrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultMatrix;
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