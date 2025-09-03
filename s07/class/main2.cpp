#include <iostream>
using namespace std;

class bigobj{
    char buf[1000*1000];
};

void test(bigobj& b){
    cout << "done test" << endl;
}

int main(){
    // bigobj* bo = new bigobj;
    // cout <<"done" << endl;
    bigobj bo;
    test(bo);
}