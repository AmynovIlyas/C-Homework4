// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int Exponentiation(int a, int b)
{
    int number = a;
    int count = 2;
    while(count <= b)
    {
        number *= a;
        count++;
    }
    return number;
}

int A = Prompt("Введите число А: ");
int B = Prompt("Введите число В: ");
Console.WriteLine($"{A}, {B} --> {Exponentiation(A, B)}");

