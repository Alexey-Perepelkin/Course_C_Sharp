// Задача 1: Напишите программу, которая на вход 
//принимает два числа и выдаёт, какое число
// большее, а какое меньшее.
Console.Write("Первое число= ");
double a = double.Parse(Console.ReadLine()!);

Console.Write("Второе число= ");
double b = double.Parse(Console.ReadLine()!);

if (a>b)Console.WriteLine ("Число " + a + " больше числа " +b);
else if (b>a)Console.WriteLine ("Число " + b + " больше числа " +a);
else Console.WriteLine ("Число " + a + " равно числу " +b);