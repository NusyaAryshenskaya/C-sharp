using static System.Console;
Clear();

WriteLine("Массив случайных вещественных чисел:  ");
double[] GetArray = GenerArray(5);

PrintArray(GetArray, 2);

WriteLine($"Разница между мин и макс элементами: = {MinMaxDif(GetArray, 2)}");

double MinMaxDif(double[] InnArray, uint round = 4)
{
    double max = InnArray[0];
    double min = InnArray[0];

    for (int i = 0; i < InnArray.Length; i++)
    {
        max = InnArray[i] > max ? InnArray[i] : max;
        min = InnArray[i] < min ? InnArray[i] : min;
    }

    return Math.Round(max - min, Convert.ToInt32(round));
}

double[] GenerArray(uint size, double BeginArray = 0, double EndArray = 10)
{
        double[] result = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = BeginArray + rnd.NextDouble() * (EndArray - BeginArray);
    }
    return result;
}

void PrintArray(double[] arr, uint round = 4)
{
    Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{Math.Round(arr[i], Convert.ToInt32(round))}, ");
    }
    Write($"{Math.Round(arr[arr.Length - 1], Convert.ToInt32(round))}]");
    WriteLine();
}