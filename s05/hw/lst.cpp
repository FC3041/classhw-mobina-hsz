#include <iostream>
using namespace std;

template <typename T>
class Lst
{
public:
    int m_len;
    T *m_lst;
    int m_capacity;

    Lst(int len, T *lst) : m_len(len), m_capacity(len)
    {
        m_lst = new T[len];
        for (int i = 0; i < m_len; i++)
        {
            m_lst[i] = lst[i];
        }
    }

    void append(T a)
    {
        resize(m_len + 1);
        m_lst[m_len  -1] = a;
    }

    void clear()
    {
        resize(0);
    }

    void print_lst()
    {
        for (int i = 0; i < m_len; i++)
        {
            cout << m_lst[i] << " ";
        }
        cout << endl;
    }

    int count(T value){
        int result=0;
        for (int i = 0; i < m_len; i++)
        {
            if(m_lst[i] == value) result++;
        }
        return result;
    }

    void extend(Lst<int>& lst2){

        for (int i = 0; i < lst2.m_len; i++)
        {
            append(lst2.m_lst[i]);
        }
        
    }

    int index(T value){
        for (int i = 0; i < m_len; i++)
        {
            if(m_lst[i] == value ) return i;
        }
        
    }

    void insert(int index , T value){
        resize(m_len + 1);
        for (int i = m_len - 1; i > index-1; i--)
        {
            m_lst[i] = m_lst[i - 1];
        }
        m_lst[index - 1] = value;
    }

    void pop(int index){
        for (int i = index+1; i <m_len; i++)
        {
            m_lst[i-1] = m_lst[i];
        }
        resize(m_len - 1);
    }

    void remove(T value){
    
        for (int i = 0; i < m_len; i++)
        {
            if(value == m_lst[i])
            pop(i);
        }
        
    }

    void reverse(){
        for (int i = 0; i < m_len/2; i++)
        {
            T temp=m_lst[i];
            m_lst[i] = m_lst[m_len - 1 - i];
            m_lst[m_len - 1 - i ] = temp;
        }
        
    }

    void sort(){
        for (int i = m_len - 1; i >=0; i--)
        {
            bool swapped = false;
            for (int j = 0; j < i; j++)
            {
                if(m_lst[j+1] < m_lst[j]){
                    T temp=m_lst[j];
                    m_lst[j] = m_lst[j + 1];
                    m_lst[j+ 1] =temp;
                    swapped = true;
                }
            }
            if (swapped == false) break;
        }
        
    }

private:
    void resize(int newlen)
    {

        while (newlen > m_capacity)
            m_capacity *= 2;
        T *newlist = new T[m_capacity];
        for (int i = 0; i < min(m_len, newlen); i++)
        {
            newlist[i] = m_lst[i];
        }
        delete[] m_lst;
        m_len = newlen;
        m_lst = newlist;
    }
};

int min(int a, int b)
{
    int min = (a > b) ? b : a;
    return min;
}

int main()
{

    int nums[5] = {1, 2, 3, 4, 5};
    int nums2[3] = {2,5,7};
    Lst<int> m2(3,nums2);
    Lst<int> m(5, nums);
    cout << "list m: ";
    m.print_lst();
    cout << "list m2: ";
    m2.print_lst();

    cout<<"m.index 5 = "<<m.index(5)<<endl;

    m.pop(2);
    cout<<"m.pop(2): ";
    m.print_lst();

    m.remove(4);
    cout << "m.remove(4): ";
    m.print_lst();

    m.insert(2,19);
    cout<<"m.inset(2,19): ";
    m.print_lst();

    m.append(6);
    cout<<"m.append(6): ";
    m.print_lst();

    m.extend(m2);
    cout << "m.extend(m2): ";
    m.print_lst();

    m.reverse();
    cout << "reverse of m: ";
    m.print_lst();

    m.sort();
    cout << "sorted m: ";
    m.print_lst();

    cout << "m.count(6): " <<m.count(6)<<endl;

    m.clear();
    m.print_lst();
}