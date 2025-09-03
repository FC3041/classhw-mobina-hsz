using System.Globalization;

namespace s12;

class Program
{
    static void Main(String[] args){
        Person Mobina = new Person("Mobina" , "hsz" , 1125);
        Person Zahra = new Person("Zahra" , "hosseni" , 1225);
        Person Ali = new Person("Ali" , "mZarei" , 2125);

        List<Person> people = new List<Person>();
        people.Add(Mobina);
        people.Add(Zahra);
        people.Add(Ali);

        people.Sort();
        for (int i = 0; i < people.Count(); i++)
        {
            System.Console.WriteLine(people[i].fname + " "+  people[i].NID);
        }
    }
    static void Main1(string[] args)
    {
        Shapes[] shapes = new Shapes[]{
            new Rectangle(5 , 10),
            new Circle(2)
        };

        double area = 0;
        double perimeter = 0;
        
        for (int i = 0; i < shapes.Length; i++)
        {
            area += shapes[i].Area();
            perimeter += shapes[i].Perimeter();
        }

        System.Console.WriteLine(area);
        System.Console.WriteLine(perimeter);
    }
}
