using static System.Console;
Clear();

WriteLine("Введите размер матрицы и диапозон значений через пробел: ");
int[] Parametr = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = GetMatrixArray(Parametr[0], Parametr[1], Parametr[2], Parametr[3]);
PrintMatrixArray(array);
WriteLine();

WriteLine("Введите строку и столбец искомого элемента через пробел: ");
GetElement(array, Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse));

void GetElement(int[,] Array, int[] size)
{
    WriteLine(size[0] >= Array.GetLength(0) || size[1] >= Array.GetLength(1)
              ? $" Такого элемента нет" : Array[size[0], size[1]]);
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