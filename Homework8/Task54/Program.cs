// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using static System.Console;

Clear();
WriteLine("Введите размер матрицы и диапозон значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] matrix = GetMatrix(intParams[0], intParams[1], intParams[2], intParams[3]);
PrintMatrix(matrix);
WriteLine();
SortRowsMatrix(matrix);
PrintMatrix(matrix);


void SortRowsMatrix(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < Matrix.GetLength(1); k++)
            {
                if (Matrix[i, j] < Matrix[i, k])
                {
                    int temp = Matrix[i, k];
                    Matrix[i, k] = Matrix[i, j];
                    Matrix[i, j] = temp;
                }
            }


        }

    }
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