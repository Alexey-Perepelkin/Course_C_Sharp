// Задача 3: Задайте двумерный массив. Найдите сумму элементов
// главной диагонали.

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)

            arr[i, j] = new Random().Next(from, to);
    }
    return arr;
}
int Sum (int[,] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);
    int result = 0;

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)

            if (i == j)
            {
                result += arr[i, j];
            }

    }
    return result;
}



int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
Console.WriteLine(Sum(mass));
