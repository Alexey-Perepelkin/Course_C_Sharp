// Задача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

int CountDays (int year,int month,int day)
{
    //int[,] Months = new int[12];
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
int  StartYears (int year)
{
    int[] FirstDayYears ={7,2,3,4,5,7,1,2,3,5,6,7,1,3,4,5,6,1,2,3,4,6,7,1,2,4,5,6};
    int[  ] Years = new int[28];
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
// string[] DaysWeek {"ПН","ВТ","СР","ЧТ","ПТ","СБ","ВС"};
// int[] Months {01,02,03,04,05,06,07,08,09,10,11,12};
// int StartYears[] = new int[28]
// while (true)
// {
    
// }

//int [ , ] t = StartYears();
 Console.WriteLine ( StartYears (2012));
// Console.WriteLine (t[0,1]);