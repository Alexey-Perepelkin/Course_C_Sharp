// Задача 1: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

void Print(double[,] arr, int roundNum,int numDigt)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    string  convertNumDoublOnText = string.Empty;
    string countSpace = string.Empty;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            convertNumDoublOnText = Convert.ToString(arr[i, j]);

            countSpace = countSpace.PadLeft((numDigt + roundNum) -  convertNumDoublOnText.Length);
            Console.Write($"{arr[i, j]}  {countSpace}");
            countSpace = string.Empty;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column, int from, int to, int roundNum)
{
    double[,] arr = new double[row, column];
    Random newNum = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)

            arr[i, j] = Math.Round((newNum.NextDouble() * (to - from) + from), roundNum);
    }
    return arr;
}


int countNumDigit(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count+=1;
}

Console.Write("Колличество строк в массиве = ");
int num_row = int.Parse(Console.ReadLine()!);
Console.Write("Колличество столбцов в массиве = ");
int num_column = int.Parse(Console.ReadLine()!);
Console.Write("Нижняя граница Random = ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Верхняя  граница Random = ");
int stop = int.Parse(Console.ReadLine()!);
Console.Write("Округлить до = ");
int roundNum = int.Parse(Console.ReadLine()!);

double[,] mass = MassNums(num_row, num_column, start, stop, roundNum);
Print(mass, roundNum,countNumDigit(stop));

