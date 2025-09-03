using System.Collections.Specialized;
public class Person : IComparable {
    public string fname;
    public string lname ;
    public int NID;

    public Person(string fname_name , string lname_name , int NID_num){
        fname = fname_name;
        lname = lname_name;
        NID=NID_num ;
    }
    public int CompareTo(object obj)
    {
        Person temp = obj as Person;
        if(temp == null) return 1;
        return this.NID.CompareTo(temp.NID);
    }    

}