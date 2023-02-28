// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);

if (a<100) Console.WriteLine("Число не имеет третий разряд");
else
    {  
    while ( a>1000 )
        {
            a = a / 10;
            Console.WriteLine("---------");
            Console.WriteLine(a);
            
        }
    Console.WriteLine("** Результат **");    
    Console.WriteLine(a % 10);
    }