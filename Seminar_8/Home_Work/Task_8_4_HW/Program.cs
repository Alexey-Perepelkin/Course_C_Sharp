

// Задача 3: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

int[,] ProductArr(int[,] arr1, int[,] arr2)
{

    int sizeRowArr1 = arr1.GetLength(0);
    int sizeColArr1 = arr1.GetLength(1);
    int sizeRowArr2 = arr2.GetLength(0);
    int sizeColArr2 = arr2.GetLength(1);
    int[,] NewArr = new int[sizeRowArr1, sizeColArr2];

    if (sizeColArr1 != sizeRowArr2) 
    {
        return null!;
    }
   
    for (int i = 0; i < sizeRowArr1; ++i)
    {
        for (int j = 0; j < sizeColArr2; ++j)
        {
            
            for (int k = 0; k < sizeRowArr2; ++k)
            { 
                NewArr[i, j] += arr1[i, k] * arr2[k, j]; 
            }
        }
    }
    return NewArr;
}


Console.WriteLine("Первый массив");
Console.Write("Колличество строк в массиве = ");
int num_row = int.Parse(Console.ReadLine()!);
Console.Write("Колличество столбцов в массиве = ");
int num_column = int.Parse(Console.ReadLine()!);
Console.Write("Нижняя граница Random = ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Верхняя  граница Random = ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass1 = MassNums(num_row, num_column, start, stop);

Console.WriteLine("Второй массив");
Console.Write("Колличество строк в массиве = ");
num_row = int.Parse(Console.ReadLine()!);
Console.Write("Колличество столбцов в массиве = ");
num_column = int.Parse(Console.ReadLine()!);
Console.Write("Нижняя граница Random = ");
start = int.Parse(Console.ReadLine()!);
Console.Write("Верхняя  граница Random = ");
stop = int.Parse(Console.ReadLine()!);

int[,] mass2 = MassNums(num_row, num_column, start, stop);


Console.WriteLine("Первый массив");
Print(mass1);
Console.WriteLine("Второй массив");
Print(mass2);
Console.WriteLine();


if (ProductArr(mass1, mass2) == null) Console.WriteLine("Не совпадают размерности матриц");
else
{
    int[,] newArray = ProductArr(mass1, mass2);
    Print(newArray);
}





