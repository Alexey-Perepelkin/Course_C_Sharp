//Задача 1 и 2 в одном коде

// Метод выводит текс задачи
void TaskText( int NumTask)
{   
    if (NumTask == 1) Console.WriteLine("Задача 1: Напишите программу, которая принимает на" +
                                        " вход трёхзначное число и на выходе показывает вторую" + 
                                        " цифру этого числа.");
    else if (NumTask == 2) Console.WriteLine ("Задача 2: Напишите программу, которая выводит " +
                                        "случайное трёхзначное число и удаляет вторую цифру "+
                                        "этого числа.");
}

// Метод возвращает результат вычисления
int NumReturn(int num, int NumTask)
{
    int result=0;
    if (NumTask == 1) 
        {
            result= num % 100;
            result=result / 10;
        }
    else if  (NumTask == 2)
        {
            result = num / 100;
            result = result*10;
            result = result + num % 10;
        }
    return result;
}
 int number = new Random().Next(100,1000);
 Console.WriteLine("Введите номер задач 1 или 2 ");
 int NumberTask = int.Parse(Console.ReadLine()!);
 
 TaskText(NumberTask);
 
 if (NumReturn( number,NumberTask) == 0) Console.WriteLine ("Что то ввели не то");
 else 
 {
    Console.WriteLine (number);
    Console.WriteLine( NumReturn( number,NumberTask));
 }
