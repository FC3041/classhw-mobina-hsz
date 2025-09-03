class Citizen{
    public string Firstname{get; set;}
    public string Lastname{get ;set;}
    public int NationalID{get; set;}
    public bool IsMale{get; set;}
    public Citizen(string f , string l , int id , bool m){
        this.Firstname = f;
        this.Lastname = l;
        this.NationalID = id;
        this.IsMale = m;
    }

    //this.ToString gived us the ToString for the class not the obj so if I wanted to override ToSring should use base not this!
    //base here means"برو تو کلاسی که ازش به ارث بردی"
    public override string ToString(){
        return $"{base.ToString}";
    }
}

    class Student : Citizen{
        //if I have a empty constructor for Citizen there is no need using a constructor for Student;

        public string major{get; set;}
        public int stdid {get; set;}
        public bool isPaying {get; set;}

        // base is the class we are calling(inhertated from)
        // if the class has been inherited from the father class we should use the constructor(base) inside the child for
        //the father class so we can use it in the child class

        // "this" is similiar to "base" but it calls the constructor of itself that has the needed parameters

        public Student (string f , string l , int id , bool m , string major , int stdid , bool isPaying)
        : base(f , l , id, m){

            this.major =major;
            this.stdid = stdid;
            this.isPaying = isPaying;
        } 
    }

    class Teacher: Citizen{
        public long Salary{get ; set ;}
        public int Rating {get ; set;}
        public bool Employed {get; set;}
        public Teacher(string f , string l , int id , bool m, long s , int r , bool e)
        :base(f,l, id,m){
            this.Salary = s;
            this.Rating = r;
            this.Employed = e;
        }
    }
    //crtl + p / reload 

    //HW1: making a teacher class using citizen class

    //partial class means its not complete here there is other part of this class in other files
    //virtual class means that the derived(child) class can change the father


    class GradStudent : Student{
        public GradStudent(string f , string l , int id , bool m , string major , int stdid , bool isPaying)
        :base(f,l,id , m ,major, stdid, isPaying){

        }
    }

