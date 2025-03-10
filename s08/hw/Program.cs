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

    static void cut(string s, out string sout , int begin , int end){
        sout ="";
        for (int i = begin; i < end+1; i++){
            sout += s[i];
        }
    }   

    static void split(string s , out string[] sout){
        int n = count_words(s);
        sout = new string[n];
        int j=0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i]==' ')
            {
                cut(s, out sout[j] ,j , i);
                j=i;
            }            
        }
    }

    static int count_words(string sen){
        int j=1;
        for (int i = 0; i < sen.Length; i++)
        {
            if(sen[i]==' ') j++;
        }
        return j;
    }

    static void reverse_sen(string sen, out string senout)
    {   
        int n=count_words(sen);
        string[] sen_split = new string[n-1];
        senout = "";
        split(sen , out sen_split);
        int j = 0;
        for (int i = 0; i <sen.Length; i++)
        {
            System.Console.WriteLine(sen[i]);
            if (sen[i] == ' ')
            {
                senout += sen_split[n- 1-j];
                System.Console.WriteLine(senout);
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
