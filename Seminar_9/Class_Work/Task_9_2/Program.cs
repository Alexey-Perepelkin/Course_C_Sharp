// 2. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.


int ValueSet(int N)
{
    if (N == 0) return 0;
    return ValueSet(N / 10) + N % 10;
}

int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(ValueSet(num));