

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"Array: {arr[i]} ");
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
    int pos, neg;
    pos = neg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            pos += arr[i];
        else
            neg += arr[i];
    }
    Console.WriteLine($"Positive: {pos}, negative: {neg}");
}
Console.WriteLine("Input size massive:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input the lover bound array:");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input the upper bound array:");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
SumPosNeg(mass);
