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

int [] NewArr(int[] arr)
{
    int size = arr.Length;
    int newSize = size / 2 + size % 2;
    int[] newArr = new int[newSize];

    for (int i = 0; i < size / 2; i++)
    {
        newArr[i] = arr[i] * arr[size - 1 - i];
    }
    if (size%2==1) newArr[newSize-1]=arr[newSize-1];
    return newArr; 
    
}

Console.WriteLine("Input size array: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input the lover bound random: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input the upper bound random: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
NewArr(mass);
// Console.WriteLine(NewArr(mass));
Print(NewArr(mass));