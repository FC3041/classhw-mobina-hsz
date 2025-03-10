namespace Date;

class Program
{
    static bool is_leapyear(int year){
    if(year%400==0){
        return true;
    }
    else if(year%4==0 && year%100!=0){
        return true;
    }
    else{
        return false;
    }
}
    static int days_in_month(int year, int monthNumber){
    if(monthNumber<=12 && monthNumber >=1){
    if (is_leapyear(year) && monthNumber==2)
        return 29;
    else{
    if (monthNumber==1)
        return 31;
    else if( monthNumber==2)
        return 28;
    else if( monthNumber==3)
        return 31;
    else if( monthNumber==4)
        return 30;
    else if( monthNumber==5)
        return 31;
    else if( monthNumber==6)
        return 30;
    else if( monthNumber==7)
        return 31;
    else if( monthNumber==8)
        return 31;
    else if( monthNumber==9)
        return 30;
    else if( monthNumber==10)
        return 31;
    else if( monthNumber==11)
        return 30;
    else if( monthNumber ==12)
        return 31;
}}
return 0;
}

static int days_before_date(int year, int monthNumber,int dayNumber){
    int days_bofore_date = dayNumber-1;
    for ( int i =1 ; i<monthNumber ; i++){
        days_bofore_date += days_in_month(year, i);
    }
    return days_bofore_date;
}

static int day_of_the_week(int year, int monthNumber,  int dayNumber){
    int day = 4; //cuz the first day of 2014 is Wednesday
    day+=day_of_the_week(year,monthNumber,dayNumber)%7;
    return day;
}
    static void Main(string[] args)
    {
        Console.WriteLine(days_before_date(2014 , 1 ,1));
        Console.WriteLine(days_before_date(2014,12,31));
    }
}
