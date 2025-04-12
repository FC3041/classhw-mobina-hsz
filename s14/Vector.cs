

using System.Net;

class Vector : IComparable<Vector> , IEquatable{
    // class Vector<T> : IComparable<Vector> , IEquatable<Vector<T>>{
    //where T : (INumber<T>) this is the boundry for the type T it is only numbers
    public Vector(int x , int y){
        this.X = x; //this is for mentioning that i am pointing to a membervaluable
        this.Y = y;
    }
    public int X { get; set; }
    public int Y { get; set; }
    public double Magnitude => Math.Sqrt(X*X + Y* Y);
    //int vector.x = 5 -> set 
    // int a = vector.x -> get

    public Vector Add_vector(Vector v) => new Vector(v.X+ X , v.Y + Y);

    public override bool Equals(object obj) //we will override  the Equals cause it is for obj not AreEqual
    {//if i override the AreEqual method it will change it for all the objects
        Vector v = obj as Vector;
        if(v!=null) return (v.X == this.X) && (v.Y == this.Y);
        return false;
    }

    int IComparable<vector>.CompareTo(Vector v) => this.Magnitude.CompareTo(v.Magnitude); // i should link the test and program so it can read it

    public static Vector Parse(string s){
        string[] tokens = s.Split(',');
        return new Vector(int.Parse(tokens[0]) , int.Parse(tokens[1]));
    }
    //^ this the symbol for XOR
    //HashCode is a Code that if for two objects will be equal then the two objects are equal.
}
