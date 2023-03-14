// Задача 4: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

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

int[] NewArr(int[] arr)
{
    int size = arr.Length;
    int newSize = size / 2 + size % 2;
    int[] newArr = new int[newSize];

    for (int i = 0; i < size / 2; i++)
    {
        newArr[i] = arr[i] * arr[size - 1 - i];
    }
    if (size % 2 == 1) newArr[newSize - 1] = arr[newSize - 1];
    return newArr;

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
    int[] NewMass = NewArr(mass);
    Print(mass);
    NewArr(mass);
    Print(NewMass);






