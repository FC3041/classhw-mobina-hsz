#include <iostream>
using namespace std;
template <typename T>

class Lst{
    int len;
    T values[40];
    public :

    void reverse(){
        for (int i = 0; i < len/2; i++)
        {
            temp=values[i];
            values[i]=values[len - 1 - i];
            values[len - 1 -i] = temp ;
        }       
    }

    void append(val){
        values[len] = val;
        len ++;
    }

    void insert(val , indx){
        for(int i = indx ; i<len ; i++ ){
            values[i+1] = values[i]
        }
        values[indx] = val;
        len++;
    }

    void erase(indx){
        for (int i = indx; i < len; i++)
        {
            values [i-1] = values[i];
        }
        len --;
    }

    void clear(){
        for (int i = 0; i < len; i++)
        {
            
        }
        
    }

};