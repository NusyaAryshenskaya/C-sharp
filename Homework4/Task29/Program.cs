using static System.Console;
Clear();

WriteLine("Массив случайных целых чисел: ");

void Printarray (){
    int[] array = new int[8];
    Random random = new Random();

    for (int i = 0; i < 8; i++)
    {
        array[i] = random.Next(0,100);
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length-1) WriteLine(array[i]);
        else Write($"{array[i]}, ");
    }
}

Printarray();