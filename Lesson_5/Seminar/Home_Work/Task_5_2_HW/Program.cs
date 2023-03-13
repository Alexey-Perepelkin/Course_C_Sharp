// Задача 2: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

void Print(int[] arr)
{
    int size = arr.Length;
    Console.Write($"Array: ");
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void SumPosNeg(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length + 1; i++)
    {
        if (i % 2 == 1)
            result = result + arr[i - 1];
    }
    Console.WriteLine($"Sum of numbers at odd array position: Sum = {result}");
}
Console.WriteLine("Input size array: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input the lover bound random: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input the upper bound random: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
SumPosNeg(mass);
