// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt()
{
    Console.WriteLine("Введите число: ");
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int SumNumber(int num)
{
    int result = 0;
    while(num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

int number = Prompt();
Console.WriteLine($"{number} --> {SumNumber(number)}");
