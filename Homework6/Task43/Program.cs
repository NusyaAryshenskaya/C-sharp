using static System.Console;
Clear();

WriteLine("Точка пересечения двух прямых: y = k1 * x + b1, y = k2 * x + b2");

double b1 = CheckInput("Введите b1: ");
double k1 = CheckInput("Введите k1: ");
double b2 = CheckInput("Введите b2: ");
double k2 = CheckInput("Введите k2: ");

if (k1 == k2 && b1 == b2)
{
    WriteLine("ЛПрямые одинаковые (сливаются в одну)");
}
else if (k1 == k2)
{
    WriteLine("Прямые не пересекаются, они паралельные");
}
else
{
    double x = (b2-b1) / (k1 - k2);
    double y = (k1 * (b2-b1))/ (k1-k2) + b1;
    WriteLine($"Точка пересечения: x={x}, y={y}");
}


double CheckInput(string message)
{
    Write(message);
    if (!double.TryParse(ReadLine(), out double result))
    {
        Environment.Exit(0);
    }

    return result;

}