namespace LeapYear;

class Program
{
    static void is_leap_year(int year){
        if((year%4==0 && year%100!=0)|| year%400==0){
            Console.WriteLine("True");
        } 
        else
        Console.WriteLine("False");
    }
    static void Main(string[] args)
    {
    is_leap_year(1792);
	is_leap_year(1796);
	is_leap_year(1800);
	is_leap_year(1804);
	is_leap_year(1900);
	is_leap_year(1904);
	is_leap_year(2000);
    is_leap_year(2004);
    }
}
