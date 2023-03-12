// Задача 3
// Напишите программу, которая принимает на 
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cub(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{Math.Pow(i, 3)}");
    }
}
Cub(5);