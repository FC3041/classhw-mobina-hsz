#include<iostream>
using namespace std;
// template <typename T>
class Vector{
    public:
    int m_size;
    int m_capacity;
    int* m_nums;
    Vector(int* nums,int size):m_size(size) , m_capacity(size){
        m_nums = nums;
    }

    int at(int index){
        if(m_size>index){
            return *(m_nums+index);
        }
    }

    void push_back(int value){
        resize(m_size + 1);
        m_nums[m_size - 1] = value;
    }

    int* begin(){
        int* p = m_nums;
    }

    void insert(int * p , int value){
        resize(m_size + 1);
        *p=value;
    }

    void erase(int* p){
        for(int i= p - begin(); i<m_size ; i++){
            *(p) = *(p+1);
            p = p+1;
        }
        resize(m_size - 1);
    }

    void clear(){
        resize(0);
    }


    private:
    void resize(int size){
        int* new_nums = new int[m_size];
        new_nums = m_nums;
        delete[] m_nums;
        while(size > m_capacity){
            m_capacity*=2;
            m_nums = new int[m_capacity];
        }
            m_size = size;
            m_nums = new_nums;
            delete[] new_nums;
    }

};


int main(){
    int nums[5] = {1,2,3,4,5};
    Vector vnums(nums , 5);

    cout << vnums.at(3)<<endl;
    vnums.push_back(6);
    cout << vnums.at(5) << endl;
    cout << vnums.m_size << endl;
    cout << vnums.m_capacity << endl; 
}