// Задача 3: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;
    Console.Write($"Array: ");
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = Math.Round( new Random().NextDouble() * (to-from)+from,2);
    return arr;
}

void SumPosNeg(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    string result = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    result = $"min number = {min} ---- max number = {max}";
    Console.WriteLine(result);
}
Console.WriteLine("Input size array: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input the lover bound random: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input the upper bound random: ");
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
SumPosNeg(mass);
