namespace hw;

class Program
{

    static void Main(string[] args)
    {
        Student[] students = new Student[args.Length];

        for(int i=0 ; i<args.Length ; i++){
            students[i]= Student.Parse(args[i]); 
        }

        foreach(Student s in students){
            File.AppendAllLines("signing.txt" , new string[]{s.ToString()});
        }

    }
}
