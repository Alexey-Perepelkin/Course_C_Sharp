// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


int CountNumAboveZero(string value)
{
    int resultCount=0;
    string[] Sp = value.Split(',');
    for (int i = 0; i < Sp.Length; i++)
    {
        int num = int.Parse(Sp[i]);
        if (num > 0) resultCount++;
    }
    return resultCount;
}
Console.WriteLine("Input some numbers. Example - 1,2,3,4,-1: ");
string Str = Console.ReadLine()!;
int count = CountNumAboveZero(Str);
Console.WriteLine(count);