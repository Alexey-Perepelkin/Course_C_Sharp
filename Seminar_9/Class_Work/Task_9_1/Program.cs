// 1. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.


void ValuesSet(int M, int N)
{
    if (N < M) return;
    ValuesSet(M , N- 1);
    Console.Write($"{N} ");
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
ValuesSet(num1, num2);