// Задача 2: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.

int Prod(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}
Console.Write("Input number:");
int num = int.Parse(Console.ReadLine()!);
int Result = Prod(num);
Console.WriteLine(Result);