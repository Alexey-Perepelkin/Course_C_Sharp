// Задача 2. Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

int SumNumb (int num)
{
    int result = 0;
    while (num>0)
    {
        result=result+ (num % 10);
        num = num/10;
    }
    return result;

}

Console.WriteLine ("Input number: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNumb(number));