#include<iostream>
#include<string.h>
using namespace std;

class Date{
    public:

    int day;char month[10] ; int year;
    Date(int y , char* m , int d):year(y) , day(d){
        strcpy(month,m);
    }
    void print_date(){
        cout << year << "/"<< month <<"/"<< day << endl;
    }
};

class Person{
    public:

    char name[20]; char l_name[20];
    Date b_day; int id;
    Person(char* fname , char* lname , Date bday , int p_id):b_day(bday){
        id = p_id;
        strcpy(name , fname); strcpy(l_name , lname);
    }
    
    void print_person(){
        cout << "name:" << name <<" " << l_name<< endl;
        cout << "date:";
        b_day.print_date();
        cout << "personal ID:" << id << endl;
    }
};

int main(){
    char fname[10]="mobina";
    char lname[10] ="hsz";
    char month[10] ="October";
    Date d(4,month,4);
    Person Mobina("",name ,d , 112);
    Mobina.print_person();
}