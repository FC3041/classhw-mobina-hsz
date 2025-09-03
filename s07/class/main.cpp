#include<iostream>
#include<string>
#include<stdio.h>
#include<Windows.h>
using namespace std;


class Myvector{
    public:
    Myvector(int capacity=10):m_capacity(capacity),m_buffer(new int[capacity]){

    }

    ~Myvector(){
        delete[] m_buffer;
        m_capacity = 0;
    }

    void add(int e){
        m_buffer[m_size];
        m_size++;
    }

    int at(int i){
        return m_buffer[i];
    }

    private:
    int m_capacity;
    int* m_buffer;
    int m_size;
};

class myfile{
    string m_filename;
    FILE* m_filehandler;
    public:
    myfile(const string& filename):m_filename(filename){
        m_filehandler= fopen(m_filename.c_str(),"r");
    }

    ~myfile(){
        fclose(m_filehandler);
    }

    void writeln(const string &str){
        fprintf(m_filehandler, str.c_str());
    }

};

// class 

int main(){
    unsigned long long l = GetTickCount();
    cout << l << endl;
    unsigned long long l2 = GetTickCount();
    cout << l2 << endl;
}
