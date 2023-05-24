// 2 вариант решения 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int Exponentiation(int powerBase, int exponent)
{
    int power = 1;
    for(int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель: ");
if (ValidateExponent(exponent))
{
    Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Exponentiation(powerBase, exponent)}");
}

