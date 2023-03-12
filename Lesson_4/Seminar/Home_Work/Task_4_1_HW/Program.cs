// Задача 1. Напишите цикл, который принимает на вход два
// числа (A и B) и возводит число A в натуральную степень B.

 double Exp( double A, double B)
{
    
    return Math.Pow(A,B);

 
}
double a = double.Parse(Console.ReadLine()!);   
double b = double.Parse(Console.ReadLine()!);  


double result=Exp(a,b);
Console.WriteLine(result);
