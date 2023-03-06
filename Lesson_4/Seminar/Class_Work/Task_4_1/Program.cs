// Задача 1: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int Count(int num)
{   int i=0;
    for ( i = 0; num > 0; i++)
    {
        num = num / 10;
    }
    return i;
}
Console.Write("Input number: ");
int Number = int.Parse(Console.ReadLine()!);
int CountNum = Count(Number);
Console.WriteLine(CountNum);