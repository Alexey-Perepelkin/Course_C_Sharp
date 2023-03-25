// 4. Напишите программу, которая на вход принимает два числа A и B,
//    и возводит число А в целую степень B с помощью рекурсии.


int ValuesSet(int A, int B)
{
    if (B == 0) return 1;
    return ValuesSet(A, B - 1) * A;


}

int numA = int.Parse(Console.ReadLine()!);
int numB = int.Parse(Console.ReadLine()!);

Console.WriteLine(ValuesSet(numA, numB));