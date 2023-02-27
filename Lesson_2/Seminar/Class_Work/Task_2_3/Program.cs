// 4. Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23

void Task3Num(int num)
{
    if ( num % 7 == 0 & num % 23 == 0) Console.WriteLine(num + " кратно и 7 и 23");
    else Console.WriteLine("нет");
        
}

Task3Num (45);