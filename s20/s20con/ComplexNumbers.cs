public class ComplexNumber{
    public double Re;
    public double Im;
    public ComplexNumber(double re, double im){
        this.Re = re;
        this.Im = im;
    }

    public void printCN(){
        System.Console.WriteLine($"{this.Re} + {this.Im}i"); 
    }

    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) => new ComplexNumber(a.Re + b.Re , a.Im + b.Im);

    public double this[int i] {
        get {
            if (i == 0) return Re;
            else if (i == 1) return Im;
            else throw new IndexOutOfRangeException("index is out of range!");
        }
        set {
            if (i == 0) {
                Re = value;
            }
            else if (i == 1) {
                Im = value;
            }
            else throw new IndexOutOfRangeException("index is out of range!");
        }
    }

    public double this[bool b]{
        get {
            if(b) return Re;
            return Im;
        }
        set{
            if(b) Re = value;
            else Im = value;
        }
    }

    public static explicit operator double (ComplexNumber c) {
        return c.Re;
    }

    public static implicit operator ComplexNumber (double b) {
        return new ComplexNumber(b,b);
    }
}
