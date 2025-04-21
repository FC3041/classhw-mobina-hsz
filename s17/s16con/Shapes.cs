//abstract class
// its like interfaces with the difference they can store some data and have fields
// anything is abstract is virtual too
// we should write the abstract methods in inherited class from the abstract class
//the others if they are PROTECTED or PUBLIC we can use them without writing them again

class Vector{
    public int x{get ; set;} public int Y{get; set;}
    public static Vector operator+(Vector v1 , Vector v2) {v1.x+=v2.x; v1.Y+=v2.Y; return v1;}
    }
abstract class Shape{
    private string Name;
    private Vector[] points;
    public void Move(Vector d){
        // foreach(var p in points){
        //     p+=d
        // } 
        //foreach cannot use for changing the value cause it copies the num
        //it is useful for calling methods

        for (int i = 0; i < points.Length; i++)
        {
            points[i]+=d;
        }
    }

    //CLONES
    //usually we make a clone in classes for changes so if it changes the other methods would not change in the first made class
}