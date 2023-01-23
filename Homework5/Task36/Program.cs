using static System.Console;
Clear();

int[] array = GetArray(6);
int sum = SumOddIndex(array);
WriteLine($"[{String.Join(", ", array)}] -> {sum}");

int [] GetArray(int size)
{
    
    int[] resultArray = new int [size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(-100, 100);
    }

    return resultArray;
}

int SumOddIndex(int[] array)
{
    int result = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) result += array[i-1];
    }

    return result;
}