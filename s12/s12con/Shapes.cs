public interface Shapes{
    public double Perimeter();
    public double Area();
}

public class Rectangle : Shapes{
    public double m_a , m_b;

    public Rectangle(double a , double b){
        m_a = a;
        m_b = b;
    }
    double Shapes.Perimeter()
    {
        return 2*(m_a+m_b);
    }

    double Shapes.Area()
    {
        return m_a*m_b;
    }

}

public class Circle : Shapes{
    public double m_r;
    
    public Circle( double r) => m_r = r;

    double Shapes.Area()
    {
        return Math.PI*m_r*m_r;
    }
    double Shapes.Perimeter()
    {
        return Math.PI*2*m_r;
    }
}

