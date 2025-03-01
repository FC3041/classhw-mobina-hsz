#include <iostream>
using namespace std;

class Mystr
{
private:
    /* data */
public:
    int m_size;
    char * m_pchars;

    Mystr():m_size(0),m_pchars(nullptr){};

    Mystr(const char* chars){
        int i;
        for (int i = 0; i < m_size; i++)
        {
            m_pchars[i] = chars[i];
        }

        for (int i = 0; chars[i]!='\0'; i++)
        {
           m_size = i+1;
        }
        m_pchars[m_size] = '\0';
    }

    Mystr(const char* chars , int start , int count): m_size(count){
        m_pchars= (char*)malloc(sizeof(char)*(m_size));
        for(int i =0 ; i<m_size ; i++){
            m_pchars[i] = chars[start + i];
        }
        m_pchars[count] = '\0';
    }

    void print_str(){
        cout << m_pchars << endl;
    }

    bool check_substr(Mystr s1){

    }
};

int main(){
    Mystr s1;
    Mystr s2("mobina",2,4);
    s2.print_str();

    s2.check_substr("bin")
    
}