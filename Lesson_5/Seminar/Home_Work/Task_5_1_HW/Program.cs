// Задача 1: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

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
   int count =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 ==0) count++;
    }
    Console.WriteLine($"The even numbers:  {count}");
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
