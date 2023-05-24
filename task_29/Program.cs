// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]
// 6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]


int[] FillArray(int num)
{
    int[] array = new int[num];
    for(int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

void PrintArray(int [] num)
{
    Console.Write("{");
    for(int i = 0; i < num.Length - 1; i++)
    {
        Console.Write($"{num[i]}, ");
    }
    Console.Write(num[num.Length - 1] + "}");
}

const int number = 8;
int[] array = FillArray(number);
PrintArray(array);


