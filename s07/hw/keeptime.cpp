#include<iostream>
#include<windows.h>
using namespace std;

class keeptime{
    public:
    unsigned long long n;
    keeptime(): n(GetTickCount()){};
    int d = 0.1;
    void time(){
    for (int i = 0; i < 10000000; i++)
    {
        d*=1;
    }
}

    ~keeptime(){
        unsigned long long n2 = GetTickCount();
        cout << "the time is: " << n2 - n << "ms" <<endl;
    }
};

int main(){
    keeptime k;
    k.time();
}