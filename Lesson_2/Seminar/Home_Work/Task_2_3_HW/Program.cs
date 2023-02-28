// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.

int NumberThirdDigit (int number)
{
    int tmp ;
    if (number < 100) tmp = -1;
    else
        {  
        while ( number>1000 )number = number / 10;
        tmp = number % 10;
        }
    return tmp;
}
 //***************************************************   
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("---------------");
int temp = NumberThirdDigit (num);
if (temp == -1) Console.WriteLine("Число не содержит третий разряд");
else 
    {
        Console.WriteLine("В третьем разряде число  " + temp); 
    }