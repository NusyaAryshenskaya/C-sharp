using static System.Console;
Clear();

WriteLine("Введи координаты первой точки:");
Write("по оси X:");
int ax = int.Parse(ReadLine()!);
Write("по оси Y:");
int ay = int.Parse(ReadLine()!);
Write("по оси Z:");
int az = int.Parse(ReadLine()!);

WriteLine("Введи координаты второй точки:");
Write("по оси X:");
int bx = int.Parse(ReadLine()!);
Write("по оси Y:");
int by = int.Parse(ReadLine()!);
Write("по оси Z:");
int bz = int.Parse(ReadLine()!);

int x = ax - bx;
int y = ay - by;
int z = az - bz;

double length = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)) + Math.Pow(z, 2));

WriteLine($"Длина отрезка {(length)} ");
