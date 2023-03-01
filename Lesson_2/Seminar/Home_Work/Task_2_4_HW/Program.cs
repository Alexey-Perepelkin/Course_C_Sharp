// Задача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

int CountDays (int year,int month,int day)
{
    int[] CountDaysMonth = {31,28,31,30,31,30,31,31,30,31,30,31};
    if (year % 4 == 0) CountDaysMonth [1]=29;
    int index = 0;
    int tmpday = 0 ;
    int tmpmonth = 0;
    if (day > CountDaysMonth[month-1]) tmpday = -1;
    else
        while (index < month)
        {
            tmpday= day + tmpmonth; 
            tmpmonth= tmpmonth + CountDaysMonth[index];
            index ++;
        }
    return tmpday;
}
int  FirstDayYear (int year)
{
    int[] FirstDayYears ={7,2,3,4,5,7,1,2,3,5,6,7,1,3,4,5,6,1,2,3,4,6,7,1,2,4,5,6};
    int index = 0;
    int YearTemp = 1900;
    int firstDay = -1;
    while (index < FirstDayYears.Length)
    {
        if ((year-YearTemp) % 28 == 0) 
        {
           firstDay = FirstDayYears[index];
        }    
        YearTemp++;
        index++;
    }

    return firstDay ;
}


int Sum (int a, int d)
{
    int summa = a+d-1;
    int result = 0;
    if (summa <8) result = summa;
    else result =summa % 7;
    return result;
}



Console.WriteLine("Введите число (DD)");
int InDay = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите месяц (MM)");
int InMonth = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите год (YYYY)");
int InYear = int.Parse(Console.ReadLine()!);
string[] DaysWeek = {"ПН","ВТ","СР","ЧТ","ПТ","СБ","ВС"};

if (CountDays(InYear,InMonth,InDay) == -1) Console.WriteLine("Такого числа нет в этом месяце");
else
{
    int Day = FirstDayYear(InYear);
    int DayEnd = CountDays(InYear,InMonth,InDay) % 7;
    int index = Sum (Day,DayEnd)-1;
    Console.WriteLine (DaysWeek[index]);
    if (index == 5 | index == 6) Console.WriteLine("Выходной день");
    else Console.WriteLine("Рабочий день");
}    