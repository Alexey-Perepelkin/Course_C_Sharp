// Задача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

int CountDays (int year,int month,int day)
{
    //int[,] Months = new int[12];
    int[] CountDaysMonth = {31,29,31,30,31,30,31,31,30,31,30,31};
    if (year % 4 == 0) CountDaysMonth [1]=28;
    int index = 0;
    int tmpday = 0 ;
    int tmpmonth = 0;
    while (index < month)
    {
        tmpday= day + tmpmonth; 
        tmpmonth= tmpmonth + CountDaysMonth[index];

    }
    return tmpday;
}
int [,] StartYears ()
{
    int[] FirstDayYears ={0,1,2,3,4,6,0,1,2,4,5,6,0,2,3,4,5,0,1,2,3,5,6,0,1,3,4,5};
    int[ , ] Years = new int[28,2];
    int index = 0;
    int Year = 1900;
    // Console.WriteLine (FirstDayYears.Length);
    while (index < FirstDayYears.Length)
    {
        Years[index,0] = Year;
        Years[index,1] = FirstDayYears[index];
        Year++;
        index++;
    }
    return Years ;
}
// string[] DaysWeek {"ПН","ВТ","СР","ЧТ","ПТ","СБ","ВС"};
// int[] Months {01,02,03,04,05,06,07,08,09,10,11,12};
// int StartYears[] = new int[28]
// while (true)
// {
    
// }

//int [ , ] t = StartYears();
 Console.WriteLine ( CountDays (2020, 01, 22));
// Console.WriteLine (t[0,1]);