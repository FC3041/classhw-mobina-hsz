// See https://aka.ms/new-console-template for more information
using System.Data.SqlTypes;
using System.Net;
using System.Numerics;

Console.WriteLine("Hello, World!");

public static class Basic
{
    //if it is static then there is no need to use new!
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}

public class ComplexNumber<T> where T : INumber<T>
{
    public T Img;
    public T Real;
    public ComplexNumber(T re, T im)
    {
        this.Img = im;
        this.Real = re;
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


