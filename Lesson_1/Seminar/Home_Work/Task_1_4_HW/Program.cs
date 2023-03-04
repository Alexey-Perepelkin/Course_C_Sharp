// Задача 4: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все
// чётные числа от 1 до N.

Console.WriteLine("Введите число больше или равно 1");
int a = int.Parse(Console.ReadLine()!);
int count = 1;
int tmp = a;
if (a % 2 == 1)  tmp = a-1;
while (a < 1) 
{
    Console.WriteLine("Число должно быть больше или равно 1!");
    Console.WriteLine();
    Console.WriteLine("Введите число больше или равно 1");
    a = int.Parse(Console.ReadLine()!); 
}
while (count<=a)
{
    if (a <2) 
    {
        Console.WriteLine( "нет четных чисел");
        break;
    }    
    else 
    {
        if (count % 2 == 0) 
       {
            Console.Write(count );
            if ( count % tmp == 0   )
            Console.Write(";");
            else Console.Write(", ");
       }     
    }
    count++;
}
Console.WriteLine( );