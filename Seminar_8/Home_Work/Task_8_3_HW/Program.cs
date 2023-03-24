// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($"{arr[i, j]}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}


int NumberString(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int sum = 0;
    int minSum = 0;
    int numStr = 0;

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            sum = sum + arr[i, j];
            if (i < 1)
            {
                minSum = sum;
            }
        }
        if (sum < minSum)
        {
            minSum = sum;
            numStr = i;
        }
        sum = 0;
    }
    return numStr;
}


Console.Write("Колличество строк в массиве = ");
int num_row = int.Parse(Console.ReadLine()!);
Console.Write("Колличество столбцов в массиве = ");
int num_column = int.Parse(Console.ReadLine()!);
Console.Write("Нижняя граница Random = ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Верхняя  граница Random = ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
int NumString = NumberString(mass);

Print(mass);
Console.WriteLine($"Строка номер {NumString} с наименьшей суммой");


