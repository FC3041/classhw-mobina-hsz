#include <iostream>
#include<vector>
using namespace std;

int main(){
    int arr[] = {1,2,3,4};
    int * parr = arr;
    cout << arr <<endl;
    cout << parr <<endl ;
    cout << &arr <<endl;
}