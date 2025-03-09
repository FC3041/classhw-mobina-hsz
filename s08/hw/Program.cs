namespace hw;

class Program
{

    static void reverse(string s1 , out string sout){
        sout = "";
        foreach(char c in s1)
        {
            sout = c + sout;
        }
    }

    static void reverse_whole_sen(string sen , out string senout){
        reverse(sen , out senout);
    }


    static void reverse_sen(string sen, out string senout)
    {
        senout = "";
        int j = 0;
        for (int i = 0; i < sen.Length; i++)
        {
            // System.Console.WriteLine(sen[i]);
            if (sen[i] == ' ')
            {
                while (j < i)
                {
                    senout = sen[i-j] + senout;
                    j++;
                }
                senout += " ";
                // System.Console.WriteLine(senout);
            }
        }
    }

    static void Main(string[] args)
    {
        string s1 = "I love coding";
        string s2;
        reverse_sen(s1 , out s2);
        System.Console.WriteLine(s2);
    }
}
