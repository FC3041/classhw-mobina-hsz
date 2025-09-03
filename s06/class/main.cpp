#include<iostream>
#include<stdlib.h>
using namespace std;


class MyList
{
    public:
        int m_size;
        int m_capacity; // TODO1: new_size = size*2
        int* m_Pnums;

    MyList(int size, int *nums)
    :m_size(size)
    {
        m_Pnums = (int*)malloc(sizeof(int)*size);
        int i;
        for(i=0; i<m_size;i++)
        {
            m_Pnums[i] = nums[i];
        }
    }

    void append(int value)
    {
        resize(m_size+1);
        m_Pnums[m_size-1] = value;
    }

    void insert(int index , int value){
        if(m_size==m_capacity){
            if(m_size==0) resize (1);
            else resize (m_capacity*2);
        }
        for (int i=m_size ; i>=index; i--){
            m_Pnums[i+1] = m_Pnums[i];
        }
        m_Pnums[index] = value;
        m_size++;
    }

    void clear(){
        m_size = 0;
        resize(1);

    }

    void erase(int index)
    {
        for (int i = index ; i<m_size - 1 ; i++){
            m_Pnums[i] = m_Pnums[i+1];
        }
        m_size --;
    }

    void reverse(){
        for (int i = 0 ; i<m_size/2 ; i++){
            int temp = m_Pnums[i];
            m_Pnums[i] = m_Pnums[m_size -1- i];
            m_Pnums[m_size -1 - i] = temp;
        }
    }

    private:
    void resize(int newsize)
    {
        if (newsize <= m_size)
            return;

        int* newMem = (int*)malloc(sizeof(int)*newsize);
        int i=0;
        for(i=0; i<m_size;i++)
        {
            newMem[i] = m_Pnums[i];
        }
        free(m_Pnums);
        m_size = newsize;
        m_Pnums = newMem;
        //newMem = NULL;
    }
};

int main()
{
    int nums[5] = {1,2,3,4,5};
    MyList m(5, nums);
    m.append(14);
    m.reverse();
    for (int i = 0; i < m.m_size; i++)
    {
        cout << m.m_Pnums[i] << "," ;
    }
    
}