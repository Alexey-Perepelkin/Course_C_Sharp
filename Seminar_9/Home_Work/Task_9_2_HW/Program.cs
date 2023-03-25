// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.



int ValuesSet(int first, int end)
{
    if (end < first) return 0;
    return ValuesSet(first, end - 1) + end;
}

int num = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int sum = ValuesSet(num, num2);

Console.WriteLine(sum);