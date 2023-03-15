// Задача 1: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
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

void RewMas(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);
    }
}

int num;
int start;
int stop;

Console.WriteLine("Input size array: ");
string InSize = Console.ReadLine()!;
bool resiltInSize = int.TryParse(InSize, out num);

if (!resiltInSize)
{
    Console.WriteLine("Not correct size array!");
    return;
}

Console.WriteLine("Input the lover bound random: ");
string LBoundRand = Console.ReadLine()!;
bool resultInLBound = int.TryParse(LBoundRand, out start);

if (!resultInLBound)
{
    Console.WriteLine("Not correct lover bound random!");
    return;
}

Console.WriteLine("Input the upper bound random: ");
string UBoundRand = Console.ReadLine()!;
bool resultInUBound = int.TryParse(UBoundRand, out stop);

if (!resultInUBound)
{
    Console.WriteLine("Not correct upper bound random!");
    return;
}

if (start > stop)
{
    Console.WriteLine("WARNING! Lover bound random more than" +
    " upper bound random. Values will be changed.");
    (start, stop) = (stop, start);
}
int[] mass = MassNums(num, start, stop);

Print(mass);
RewMas(mass);
Print(mass);
