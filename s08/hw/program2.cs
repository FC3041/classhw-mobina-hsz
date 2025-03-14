namespace hw
{
    class Program2
    {
    static int count_words(string sen){
        int j=1;
        for (int i = 0; i < sen.Length; i++)
        {
            if(sen[i]==' ') j++;
        }
        return j;
    }
        static void reverse(string s,out string sout){
            sout ="";
            string[] ssplit = new string[count_words(s)];
            ssplit=s.Split();
            for (int i = 0; i < count_words(s); i++)
            {
                sout = ssplit[i]+" " + sout;
            }
        }

        static void Main1(string[] args)
        {
            string sen = "I love coding";
            string s2;
            reverse(sen , out s2);
            System.Console.WriteLine(s2);

        }
    }
}
