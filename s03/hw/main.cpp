#include <iostream>
#include<string.h>
#include<stdlib.h>

using namespace std;

class Student{
    public:
    int grades[40] ; 
    int credits[40];
    char lesson[10][40];
    char fname[40]; char lname[40]; int stdnum;

    Student(const char* firstname , const char* lastname, const int student_number){
        strcpy(fname , firstname);
        strcpy(lname , lastname);
        stdnum = student_number;
    }

    void get_courses(char* course,int n){
        strncpy(lesson[n], course,sizeof(lesson[n]-1));
    }

    void listing(int courses){
        for(int j=0; j<courses ; j++){
            cout << lesson[j] << " " << credits[j] <<" "<< grades[j] << endl;
        }
    }
    ~Student(){
        
    }
};

int main(){
    char fn[40];
    char ln[40];
    int stdnum;
    cout<<"firstname?";
    cin>> fn;
    cout<<"lastname?";
    cin>> ln;
    cout << "student number?";
    cin >> stdnum;
    Student Mobina(fn , ln, stdnum);
    int i=0;
    char input[10];
    while (true)
    {
        cout<< "lesson?";
        cin >> input;
        if(*input == 'A') break;
        Mobina.get_courses(input,i);
        cout << "credits?";
        cin >> Mobina.credits[i];
        cout << "grade?";
        cin >> Mobina.grades[i];
        i++;
    }
    cout<<"firstname: "<<fn<<endl;
    cout << "lastname: " << ln<<endl;
    cout << "student number: " << stdnum<<endl;
    Mobina.listing(i);

}