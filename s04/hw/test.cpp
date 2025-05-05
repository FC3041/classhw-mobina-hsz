#include <iostream>
int main(){
    int arr[5] = {0};
    for (int i = 0; i < 5 - 1; i++)
    {
        std :: cout << arr[i] << ",";
    }
    std ::  cout << arr[4];
}