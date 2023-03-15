// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void PointEntersection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
    
    else
    {
        double crossX = (b2 - b1) / (k1 - k2);
        double crossY = (k1 * b2 - b1) / (k1 - k2) + b1;
        Console.WriteLine($"Точка Х = {crossX}");
        Console.WriteLine($"Точка y = {crossY}");
    }
}

 Console.WriteLine("Input b1: ");
 double b1=Convert.ToDouble(Console.ReadLine()!);
 Console.WriteLine("Input k1: ");
 double k1=Convert.ToDouble(Console.ReadLine()!);
 Console.WriteLine("Input b2: ");
 double b2=Convert.ToDouble(Console.ReadLine()!);
 Console.WriteLine("Input k2: ");
 double k2=Convert.ToDouble(Console.ReadLine()!);

 PointEntersection(b1,k1,b2,k2);