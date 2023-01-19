using static System.Console;
Clear();

Write("Введи число A: ");
int A = int.Parse(ReadLine()!);

Write("Введи число B: ");
int B = int.Parse(ReadLine()!);

WriteLine(exponent_A_to_B(A, B));


int exponent_A_to_B (int A, int B)
{
    int result = 1;
    for(int i = 0; i < B; i++){
        result *= A;
    }

    return result;
}