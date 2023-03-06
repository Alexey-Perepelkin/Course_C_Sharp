// Задача 1
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.


int NumberDigit(int num)
{
    int count = 1;
    while (num > 10)
    {
        num = num / 10;
        count++;
    }
    return count;
}

void NumberCheck(int num, int digits)

{
    int count = 0;
    for (int i = 0; i < digits / 2; i++)
    {
        int FirstDigitNum = num % 10;
        int LastDigitNum = num / Convert.ToInt32(Math.Pow(10, (digits - 1) - count));
        if (FirstDigitNum == LastDigitNum)
        {
            num = num / 10;
            num = num % Convert.ToInt32(Math.Pow(10, (digits - 2) - count));
            count = count + 2;
        }
        else
        {
            Console.WriteLine("Это не палиндром");
            return;
        }
    }
    Console.WriteLine("Это палиндром");
}

Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine()!);
int DigitCount = NumberDigit(Number);
NumberCheck(digits: DigitCount, num: Number);

