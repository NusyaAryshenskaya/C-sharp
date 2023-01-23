using static System.Console;
Clear();

int[] array = GetArray(10);
int countEven = GEtCountEven(array);
WriteLine($"[{String.Join(", ", array)}] -> {countEven}");

int [] GetArray(int size){
    
    int[] resultArray = new int [size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(100, 1000);
    }

    return resultArray;
}

int GEtCountEven(int[] array){
    int result = 0;

    foreach (int i in array)
    {
        if(i % 2 == 0 ) result++;
    }

    return result;
}