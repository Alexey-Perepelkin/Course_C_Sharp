// Задача 2
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.


double DistanceBetweenCoord(double x1,double y1,double z1,double x2, double y2 ,double z2)
{
    double Result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    return Math.Round(Result,2);
}

Console.WriteLine("Введите 1-ю координату ");
string FirstCoord = Console.ReadLine()!;
Console.WriteLine("Введите 2-ю координату ");
string SecondCoord = Console.ReadLine()!;
string[] SpFirstCoord =FirstCoord.Split(',');
string[] SpSecondCoord=SecondCoord.Split(',');

int x1 = int.Parse(SpFirstCoord[0]);
int y1 = int.Parse(SpFirstCoord[1]);
int z1 = int.Parse(SpFirstCoord[2]);

int x2 = int.Parse(SpSecondCoord[0]);
int y2 = int.Parse(SpSecondCoord[1]);
int z2 = int.Parse(SpSecondCoord[2]);


Console.WriteLine(DistanceBetweenCoord(x1,y1,z1,x2,y2,z2));