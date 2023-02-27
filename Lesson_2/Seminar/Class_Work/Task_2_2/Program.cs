// 3. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.
void Task3Num(int num1, int num2)
{
    Console.WriteLine( num1 );
    Console.WriteLine( num2 );
    if (num1 % num2 == 0) Console.WriteLine("Кратно");
    else Console.WriteLine($"не кратно,остаток   { num1 % num2}"); 
}
Task3Num(34,6);