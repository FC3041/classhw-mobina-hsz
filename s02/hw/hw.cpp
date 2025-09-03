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

class Cirlce{
    public:
    double x ; double y; double r;

    Cirlce(double a , double b , double c){
        x = a; y=b ; r = c;
    }

    double calculate_perimeter(){
        return 2*r*M_PI;
    }

    double calculate_area(){
        return r*r*M_PI;
    }

    double dist_center(Cirlce c2){
        double dist_x = x - c2.x;
        double dist_y = y - c2.y;
        return sqrt(pow(dist_x,2)+ pow(dist_y,2));
    }

    bool is_init(Point p1){
        double dist_x = x-p1.x;
        double dist_y = y - p1.y;
        double dist = sqrt(pow(dist_x,2) + pow(dist_y,2));
        if(dist<=r) return true;
        return false;
    }

    double point_dist(Point p1){
        double dist_x = x - p1.x;
        double dist_y = y - p1.y;
        double dist = sqrt(pow(dist_x,2) + pow(dist_y,2));
        if(is_init(p1)) return r - dist;
        return dist - r;
    }

};

int main(){
    
}