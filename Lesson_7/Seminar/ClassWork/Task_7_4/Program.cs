// Задача 4: Задайте двумерный массив. Введите элемент, и найдите
// первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет.
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
String Total(int[,] arr, int num)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);
    String Text = String.Empty;

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)

            if (arr[i, j] == num)
            {
                Text = $"Введенный элемент {num}, результат: [{i + 1},{j + 1}]";
                return Text;
            }
            
    }
    return Text = $"Введенный элемент {num}, результат: такого элемента нет";
}



int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(Total(mass, num));
