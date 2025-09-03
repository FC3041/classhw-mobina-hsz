#include <iostream>
#include<math.h>

using namespace std;

class Point{

    public:
    double x;
    double y;
    
    void print_point(){
        cout<<"x:"<<x<<",";
        cout <<"y:"<<y<<endl;
    }

    double calculate_dist(Point p2){
        double dist_x = x - p2.x;
        double dist_y = y - p2.y;
        double dist = sqrt(pow(dist_x,2) + pow(dist_y,2));
        return dist;
    }

    Point(const Point* p){
        x = p->x;
        // p->y++;
        y = p->y;
    }

    Point(const Point& p){
        x= p.x;
        y=p.y;
    }

    Point(double x0 , double y0){
        x =x0;
        y = y0;
    }

};

int main(){
    Point p1(2,2);
    Point p2(5,6);
    // p2.x = 5 ; p2.y= 6;
    // p1.x = 2 ; p1.y = 2;
    Point p3(p1);
    Point p4(&p1);

    p1.print_point();
    p2.print_point();
    p3.print_point();
    p4.print_point();
    cout<<p1.calculate_dist(p2)<<endl;

    int a = 5;
    cout  << "a:" << a << endl;
}