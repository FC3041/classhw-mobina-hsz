#include <iostream>
#include <math.h>
using namespace std;

class Point{
    public:
    double m_x;
    double m_y;

    void print_point(){
        cout << "x:" <<m_x << ",y:" << y << endl;
    }

    double distanceto(Point p1){
        double x_diff = p1.m_x - m_x;
        double y_diff = p1.m_y - m_y;
        return sqrt(x_diff*x_diff + y_diff*y_diff);
    }
};

class Circle{
    public:
    Point m_o;
    double m_r;

    Circle(const Point& o , double r):m_o(o),  m_r(r);
    Circle(){}

    double distanceto(Point p){
        return p.distanceto(m_o);
    }

    double Distanceto(Circle c){
        return distanceto(c.m_o);
    }
}