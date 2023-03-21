// Задача 1: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

void Trngl(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        Console.WriteLine($"Yes");
    else Console.WriteLine("No");
}

Trngl(2, 3, 4);