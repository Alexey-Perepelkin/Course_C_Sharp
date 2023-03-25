// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

void ValuesSet(int M, int N)
{
    if (N < M) return;
    if (N % 2 == 1) N = N - 1;
    ValuesSet(M,N - 2);
    Console.Write($"{N} ");
}

int num = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
ValuesSet(num ,num2);