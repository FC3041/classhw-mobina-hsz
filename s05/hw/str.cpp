#include<iostream>
#include<string.h>
using namespace std;


class Str{
    
    void resize(int newlen){
        m_len = newlen;
        char* newval = new char[m_len];
        newval = m_values;
        delete[] m_values;
        m_values = newval;
    }

    public:
    int m_len;
    char* m_values;
    int m_capacity;
    Str():m_len(0) , m_values(nullptr) , m_capacity(1){};

    Str(char* val):m_len(strlen(val)) , m_values(val) , m_capacity(m_len){};

    Str(const char* str2):m_len(strlen(str2)) , m_capacity(strlen(str2)+1){
        m_values = new char[m_len+1];
        int i =0;
        for (i = 0; i < m_len; i++)
        {
            m_values[i] = str2[i];
        }
        m_values[i] = 0;
        
        }

    void append(const char * str2){
        int len2 = sizeof(str2) / sizeof(char);
        int len1 =m_len;
        resize(m_len + len2 + 2);
        int j=0;
        int i=len1;
        for(i= len1; i<m_len ; i++){
            m_values[i] = str2[j];
            j++;
        }
        m_values[i] = 0;
    }

    void assign(const char* str2){
        int len2 = strlen(str2);
        resize(len2);
        int i=0;
        for (i = 0; i < m_len; i++)
        {
            m_values[i] = str2[i];
        }
        m_values[i] = 0;
    }

    int size(){
        return m_len;
    }

};

int main(){
    char m_name[4] = "ali";
    Str name(m_name);
    name.append("mobina");
    cout << name.m_values<<endl;

    name.assign("eren");
    cout<<name.m_values<<endl;

    cout << name.size()<<endl;

    cout<<"helloworld"<<endl;

    Str name2("mobina");
    cout << name2.m_values;
}