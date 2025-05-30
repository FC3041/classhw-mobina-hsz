public static class EXT{  //extention class
    //static means i dont want to use NEW!
    //we use "this" in the input of methods for extention class so it will use the string class itself
    public static string TitleCase(this string s){
        if(s==null){
            return s;
        }
        else{
            return $"{char.ToUpper(s[0]) + s.Substring(1)}";
        }
    }

    public static int CountDigits(this string s){

        if(s==null)return 0;

        int result = 0;
        // for(int i=0;i<s.Length ; i++){
        //     if(s[i]>=48 && s[i] <= 57){
        //         result ++;
        //     }
        // }

        foreach(char c in s){
            if(char.IsDigit(c)){
                result++;
            }
        }
        return result;
    }

    public static string Coder_Sezar(this string s){
        char[] result = s.ToCharArray();
        for (int i = 0; i < s.Length; i++)
        {
            char start;
            if(char.IsUpper(s[i])){
                start = 'A';
            }
            else start = 'a';

            result[i] = (char) ((s[i] - start + 3)%26 +start);
        }
        return new string(result);
    }

    public static string Decoder_Sezar(this string s){
        char[] result = s.ToCharArray();
        for (int i = 0; i < s.Length; i++)
        {
                        char start;
            if(char.IsUpper(s[i])){
                start = 'A';
            }
            else start = 'a';
            result[i] = (char)((result[i]- start + 26 -3 )%26 + start);
        }
        return new string(result);
    }
}

//"HW" : Coder and Decoder SEZAR for strings
//coder : shift 3 forward (a -> d)
//encoder shift 3 backward (d -> a)