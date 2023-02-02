// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

using static System.Console;

Clear();
WriteLine("Введите размер трехмерной матрицы через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);


if ((intParams[0] * intParams[1] * intParams[2]) < 91)
{
    int[,,] matrix = GetMatrix(intParams[0], intParams[1], intParams[2]);
    PrintMatrix(matrix);
}
else Write("Эту трехмерную матрицу, нельзя задать из неповторяющихся двузначных чисел");





int[,,] GetMatrix(int row, int column, int page)
{

    int[,,] result = new int[row, column, page];
    int[] randArray = RandArray(row * column * page);
    int count = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < page; k++)
            {
                result[i, j, k] = randArray[count];
                count++;
            }
        }
    }
    return result;
}


int[] RandArray(int size)
{
    int[] randArray = new int[size];
    Random rnd = new Random();
    int temp = 0;
    for (int i = 0; i < size; i++)
    {
        int count = 0;
        while (count != size)
        {
            count = 0;
            temp = rnd.Next(10, 100);
            foreach (int C in randArray)
                count += C != temp ? 1 : 0;
        }
        randArray[i] = temp;
    }
    return randArray;
}



void PrintMatrix(int[,,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix.GetLength(2); k++)
            {
                Write($"{Matrix[i, j, k],3} ( {i}, {j}, {k} )");
            }
            WriteLine();
        }
    }
}