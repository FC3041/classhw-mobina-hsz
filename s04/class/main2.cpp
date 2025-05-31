#include<iostream>
#include <string.h>
using namespace std;

class Date{
    public:
    int day;
    int month;
    int year;
};

class Person{
    public:
    int m_NID;
    char m_fname[20];
    char m_lname[20];
    Date m_BD;

    Person(int NID , char* fname , char* lname , Date& BD){
        m_NID = NID;
        int i;
        for(i=0 ; i<sizeof(m_fname) && fname[i]!='\0' ; i++ ){
            m_fname[i] = fname[i];
        }
        m_fname[i] = '0';
        
        for(i=0 ; i<sizeof(m_lname) && lname[i]!=0 ; i++ ){
            m_lname[i] = lname[i];
        }
        m_lname[i] =0;
    }

    void Print_person(){
        cout << "Name: " << m_fname << endl;
        cout << "lastname" << m_lname << endl;
    }
};

int main(){
    
}