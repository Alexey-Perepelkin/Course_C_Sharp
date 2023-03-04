// Задача 2: Напишите программу, которая принимает
// на вход три числа и выдаёт максимальное из этих

int[] numbers =new int[3];
Console.Write("Первое число= ");
numbers[0]=int.Parse(Console.ReadLine()!);
Console.Write("Второе число= ");
numbers[1] = int.Parse(Console.ReadLine()!);
Console.Write("Третье число= ");
numbers[2] = int.Parse(Console.ReadLine()!);

int max =numbers[0];
int index = 1;
int indexNum = 0;
while (index < numbers.Length)
{
    if (numbers[index]>max)
    {
         max=numbers[index];
         indexNum=index;
    }     
    index++;
}
Console.WriteLine("Число " + numbers[indexNum] + " самое большое");