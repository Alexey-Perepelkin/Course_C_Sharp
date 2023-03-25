// Задача 2: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

void Print(int[,] arr)
{
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
bool PosExist(int[,] arr, int row, int column)
{
    bool flag = true;
    int countRow = arr.GetLength(0);
    int countColumn = arr.GetLength(1);
    if (countRow < row && countColumn < column)
        flag = false;
    return flag;
}

void ResultSearch(int[,] arr, bool flag, int row, int col)
{
    int countRow = arr.GetLength(0);
    int countColumn = arr.GetLength(1);
    if (!flag)
    {
        Console.WriteLine("Нет такой позиции в массиве!");
        return;
    }
    for (int i = 1; i <= countRow; i++)
    {
        for (int j = 1; j <= countColumn; j++)
        {
            if (row == i && col == j)
            {
                Console.WriteLine($"Call({row},{col}).value = {arr[i - 1, j - 1]}");
                return;
            }
        }
    }

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
Print(mass);
Console.Write("Строка: ");
int rowArr = int.Parse(Console.ReadLine()!);
Console.Write("Столбец: ");
int colArr = int.Parse(Console.ReadLine()!);


bool flag = PosExist(mass, rowArr, colArr);
ResultSearch(mass, flag, rowArr, colArr);