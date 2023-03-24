// Задача 1:
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении 
// которых расположен наименьший элемент массива.

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


int[,] NewArr(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    int[,] newArr = new int[row_size - 1, column_size - 1];

    int countRow = 0;
    int countColumn = 0;
    int indexRow = 0;
    int indexColumn = 0;
    bool flag = true;
    int minNum = arr[0, 0];

    foreach (int a in arr) if (a < minNum) minNum = a;

    for (int i = 0; flag && i < row_size; i++)
        for (int j = 0;  j < column_size; j++)
            if (minNum == arr[i, j])
            {
                indexRow = i;
                indexColumn = j;
                flag = false;
            }
    for (int i = 0; i < row_size; i++)
    {
        if (i != indexRow)
        {
            countRow++;
            for (int j = 0; j < column_size; j++)
            {
                if (j != indexColumn)
                {
                    countColumn++;
                    newArr[countRow - 1, countColumn - 1] = arr[i, j];
                }
            }
        }
        countColumn = 0;
    }
    return newArr;

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
Print(NewArr(mass));