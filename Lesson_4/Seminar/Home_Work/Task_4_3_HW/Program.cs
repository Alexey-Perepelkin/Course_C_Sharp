// Задача 3: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

int[] Numbers(int arrLen)
{
    int[] arr = new int[arrLen];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("{ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("}");
}

Console.Write("Введите размерность массива: ");
int LenArr = int.Parse(Console.ReadLine()!);

int[] Array = Numbers(LenArr);
PrintArr(Array);

Console.WriteLine();