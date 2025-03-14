#include<iostream>
#include<vector>
using namespace std;

vector<int> nums = {1,2,3,4};

string print(){
    return "heello";
}

int main(){
    cout << nums.capacity()<<endl;
    cout << nums.at(2)<<endl;
    cout << *(nums.begin())<< endl;
    // cout << nums.size()<<endl;
    // nums.push_back(5);
    // cout << nums.capacity()<<endl;
    // cout << nums.size()<<endl;
}