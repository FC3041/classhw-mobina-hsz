#include<iostream>
#include<math.h>
using namespace std; 

class Point{
    public:
    double x;
    double y;
    void print_point(){
        cout<<"x:" <<x << ".y" <<y<<endl;
    }    
    double calculate_dist(Point p2){
        double x1 = x; double y1= y;
        double x2 =p2.x; double y2 = p2.y;
        double x_dif = x1 -x2;
        double y_dif = y1-y2;
        double dist = sqrt(x_dif*x_dif + y_dif*y_dif);
        return dist;
    }

    Point (double t , double r){
        x = t;
        y = r;
    }
    Point()
    {
        
    }
    // Point (Point* p1){
    //     x = p1->x;
    //     y =p1->y;
    // }

    Point (Point& p1){
        x = p1.x;
        y =p1.y;
    }
};


double calculate_dist(Point p1 , Point p2){
    double x1 = p1.x; double y1=p1.y;
    double x2 =p2.x; double y2 = p2.y;
    double x_dif = x1 -x2;
    double y_dif = y1-y2;
    double dist = sqrt(x_dif*x_dif + y_dif*y_dif);
    return dist;
}


int main()
{
    Point p1;
}
// int main12{
//     Point p1;
//     p1.x = 4;
//     p1.y = 5;

//     Point p2;
//     p2.x=-5;
//     p2.y =10;
//     cout <<p1.x << endl; //باید پابلیک تعریفش کنیم که دسترسی داشته باشیم

//     double r = calculate_dist(p1,p2);
//     cout <<"r:" <<r<<endl;
//     int a;
//     cin>>a;
//     cout<<"a:" <<a<<endl;  
//     return 0;
// }