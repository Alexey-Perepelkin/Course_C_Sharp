// Задайте две матрицы
// Напишите программу, которая будет находить произведение двух матриц


void Print(int[,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
      Console.Write($" {arr[i, j]} ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

int[,] FirstMatrix(int row, int column, int from, int to)
{
  int[,] arr = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      arr[i, j] = new Random().Next(from, to);

  return arr;
}

int[,] SecondMatrix(int row, int column, int from, int to)
{
  int[,] arr = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      arr[i, j] = new Random().Next(from, to);

  return arr;
}

int[,] MatrixComposition(int[,] arr, int[,] arr2)
{
  int[,] compositionArr = new int[arr.GetLength(0), arr2.GetLength(1)];

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
      for (int k = 0; k < arr2.GetLength(0); k++)
      {
        compositionArr[i, j] += arr[i, k] * arr2[k, j];
      }
    }
  }
  return compositionArr;
}


Console.Clear();

Console.WriteLine("Введите данные двух матриц. Число столбцов первой матрицы,");
Console.WriteLine("должно совпадать с числом строк во второй матрице");
Console.WriteLine();

Console.WriteLine("Введите количество строк первой матрицы");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок первой матрицы");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк второй матрицы");
int num_row2 = int.Parse(Console.ReadLine()!);
while (num_column != num_row2)
{
  Console.WriteLine("число столбцов первой матрицы, должно совпадать с числом строк во второй матрице");
  Console.WriteLine();
  Console.WriteLine("Введите количество колонок первой матрицы");
  num_column = int.Parse(Console.ReadLine()!);
  Console.WriteLine("Введите количество строк второй матрицы");
  num_row2 = int.Parse(Console.ReadLine()!);
}
Console.WriteLine("Введите количество колонок второй матрицы");
int num_column2 = int.Parse(Console.ReadLine()!);



Console.WriteLine("Задайте минимальное число в массиве");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте максмальное число в массиве");
int stop = int.Parse(Console.ReadLine()!);



int[,] fMatr = FirstMatrix(num_row, num_column, start, stop);
int[,] sMatr = SecondMatrix(num_row2, num_column2, start, stop);
int[,] compMatr = MatrixComposition(fMatr, sMatr);


Print(fMatr);
Print(sMatr);
Console.WriteLine("Матрица полученная произведением двух заданных матриц:");
Print(compMatr);