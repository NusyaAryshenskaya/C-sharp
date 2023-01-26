using static System.Console;
Clear();

Write("Введите числа через пробел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int count = GetCount(array);
WriteLine($"{String.Join(", ", array)} -> {count}");
int GetCount(string[] array){
    int result = 0;

    foreach (string s in array)
    {
        if(int.Parse(s) > 0) result++;
    }

    return result;
}