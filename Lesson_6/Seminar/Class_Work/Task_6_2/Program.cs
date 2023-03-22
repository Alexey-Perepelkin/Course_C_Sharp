// Задача 2: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

string Convert(int num_1)
{
    string result = "";
    while (num_1 > 0)
    {
        result = num_1 % 2 + result;
        num_1 = num_1 / 2;
    }
    return result;
}
Console.WriteLine(Convert(17));  