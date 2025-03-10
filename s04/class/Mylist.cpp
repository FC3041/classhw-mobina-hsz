#include <iostream>
using namespace std;

class Mylist{
    public:
    int m_size;
    int* m_pnums;
    
    Mylist(int * pnums , int size){
        m_size = size;
        int * m_pnums = new int[size];
        int i;
        for(i=0 ; i<m_size ;i++ ){
            m_pnums[i] = pnums[i];
        }
    }

    private:
    void resize(int newsize){
        int * newmem = new int[newsize];
        int i = 0;
        for(i=0;i<m_size;i++){
            newmem[i] = m_pnums[i];
        }
        free(m_pnums);
        m_size = newsize;
        
    }
};

int main(){
    int nums[5] = {1,2,3,4,5};
    Mylist m(nums , 5);
    m.append(14);
}