// Задача 3: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.


void Print(int[,] arr)
{
    Console.WriteLine();
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{arr[i, j]}\t");
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

void summ(int[,] arr)
{
    double result = 0;
    int count = 0;
    int rowCount = arr.GetLength(0);
    int colCount = arr.GetLength(1);
    for (int j = 0; j < colCount; j++)
    {

        for (int i = 0; i < rowCount; i++)
        {
            result = result + arr[i, j];
            count++;
        }
        Console.WriteLine(count);
        Console.Write($"Сумма {j + 1} столбца = {result}  ");

        result = result / count;
        Console.WriteLine($"Среднее арифметическое {j + 1} столбца = {Math.Round(result, 2)}");
        
        result = 0;
        count = 0;
    }

}



int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
summ(mass);