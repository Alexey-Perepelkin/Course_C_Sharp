// 2. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

int Task2Num (int num)
{
    Console.WriteLine(num);
    int a = num % 10;
    Console.WriteLine(a);
    int b =  num / 10;
    Console.WriteLine(b);
    if (a > b) return a;
    else return b;
}

int Result  = Task2Num( new Random().Next(10,100));
Console.WriteLine(Result); 