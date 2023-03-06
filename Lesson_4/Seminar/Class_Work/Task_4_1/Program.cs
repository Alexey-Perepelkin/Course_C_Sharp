// Задача 1. Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

int  Sum(int num)
{
    int result=0;
    for (int i=1;i<=num;i++)
    {
        result =result+i;
    }
    return result;
}
Console.Write("Input number:");
int num=int.Parse(Console.ReadLine ()!);
int Result =Sum(num);
Console.WriteLine(Result);