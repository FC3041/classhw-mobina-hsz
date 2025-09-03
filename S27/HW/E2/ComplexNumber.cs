using System.Numerics;

public class ComplexNumber<T> where T : INumber<T>
{
    public T Real;
    public T Img;
    public ComplexNumber(T Real, T Img)
    {
        this.Real = Real;
        this.Img = Img;
    }

    public override string ToString()
    {
        return $"{Real}+{Img}i";
    }

    public static ComplexNumber<T> operator +(ComplexNumber<T> a, ComplexNumber<T> b)
    {
        return new ComplexNumber<T>(a.Real + b.Real, a.Img + b.Img);
    }

}