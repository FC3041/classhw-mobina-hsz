#include<iostream>
#include<math.h>
using namespace std;
#define _USE_MATH_DEFINES

class Point{
    public:
    double x; double y;
    Point(double a , double b){
        x=a; y=b;
    }
};

class Circle{
    public:
    Point o; double r;

    Circle(const Point& a , double c):o(a) , r(c) {};

    double calculate_perimeter(){
        return 2*r*M_PI;
    }

    double calculate_area(){
        return r*r*M_PI;
    }

    double dist_to(Circle c2){
        return dist_to(c2.o);
    }

    bool is_init(Point p1){
        double dist_x = o.x-p1.x;
        double dist_y = o.y - p1.y;
        double dist = sqrt(pow(dist_x,2) + pow(dist_y,2));
        if(dist<=r) return true;
        return false;
    }

    double dist_to(Point p1){
        double dist_x = o.x - p1.x;
        double dist_y = o.y - p1.y;
        double dist = sqrt(pow(dist_x,2) + pow(dist_y,2));
        return dist;
    }

    double point_dist(Point p1){
        double dist  = dist_to(p1);
        if(is_init(p1)) return r - dist;
        return dist - r;
    }

};

int main(){
    Point p1(4,6);
    Circle c(Point(4,2), 2);
    cout << c.dist_to(p1) <<endl;
}