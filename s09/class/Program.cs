namespace class;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Student s = new Student(name:"Mobina hsz",
                                stdid:403521,
                                natid:228520,
                                credits: 17,
                                active:true);
    }

    object obj = new object;
    obj.Equals

    //HW make a assignment for students using args and files in cs


}

public class Student{
    public override string Tostring(){
        return $"{name}"
    }
    //public override string Tostring() => &"{name}";

    //we dont have the override for nonstatic methods

    public static Student Parse(string str){
        string[] tokens = str.Split(',');
        //name = tokens[0] -> it is wrong cause this method is static and there is no varuiable!
        var name = tokens[0];
        var stdid = int.Parse(tokens[1]); //var stdid = tokens[1] wont work cuz it would be str by the str.split
    }

    public override bool Equals(object obj){
        Student other = (Student) obj;
        //if the obj was not student it would get to the error

        if(obj is Student){
            Student other = obj as Student; //as is like cast but it wouldnt error and return null
            return name.Equals(other.name) &&
            stdid.Equals(other.stdid)
        }
        return false; //does it work on the test too?


        //or we can just make both to string by the method we just override but if that method would not work appropraitely
        //then the Equals method wouldnt work neither
    }
}
