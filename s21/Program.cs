using System.Collections.Concurrent;

namespace s21;

class Program
{

    static void Main(string[] args){
        var data =  File.ReadAllLines("children-per-woman-UN.csv")
                .Skip(1)
                .Select(line =>{
                    string[] tokens = line.Split(',');
                    string country = tokens[0];
                    int year = int.Parse(tokens[2]);
                    double rate = double.Parse(tokens[3]);
                    return (country: country, year : year, rate :rate);
                    });

        data.Join(data ,
                (d1) => (d1.country , d1.year)
                (d2) => (d2.country , d2.year)
                (d1 , d2) => (country:d1.country, y1:d1.year)
                )
            
    }
    static void Main0(string[] args)
    {
        // string[] lines = File.ReadAllLines("children-per-woman-UN.csv");
        // foreach(var item in lines.Take(10)){
            //lines.Take(10) it only use the first 10 items
        //     Console.WriteLine(item);
        // }
        
        File.ReadAllLines("children-per-woman-UN.csv")
            // .Skip(1)

            // .Where(line =>line.ToLower().Contains("iran")) 
            //"WHERE" Filters a sequence of values based on a predicate. Each element's index is used
            // in the logic of the predicate function.

            .Select(line =>{
                string[] tokens = line.Split(',');
                string country = tokens[0];
                int year = int.Parse(tokens[2]);
                double rate = double.Parse(tokens[3]);
                return (country: country, year : year, rate :rate);
            })//select will return the output in the way I want

            .GroupBy(t => t.country)//gruop each country(tuple) base on its name

            .Select(g => {
                return (country: g.Key , rate:g.Average(t => t.rate));

                //the value that the groups are made base on that named "key"
                //each group is made by several tuples(cause we use the select to return each line in tuple)
            })

            //.Where(t=> (t.year>2012) && (t.rate>3))//t stands for tuple

            .OrderBy(t=>t.rate) //it will get tuples(t) and order them by their rates  

            //.Take(5) it will take the first 5 of the sens that contains "iran"

            .ToList()

            .ForEach(line => System.Console.WriteLine(line)); //forEach is a compared func for list
    }
}
//we can use the command"dotnet run|more" if the data were to much
