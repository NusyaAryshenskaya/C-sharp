using static System.Console;
Clear();

Write("Введи M и N для вычяслениия функции Аккермана через пробел: ");

ulong[] parametr = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), ulong.Parse);

WriteLine($"A({parametr[0]},{parametr[1]}) = {Akkerman(parametr[0], parametr[1])}");

ulong Akkerman(ulong numM, ulong numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0)
    {
        return Akkerman(numM - 1, 1);
    }
    if (numM > 0 && numN > 0)
    {
        return Akkerman(numM - 1, Akkerman(numM, numN - 1));
    }
    return 0;
}