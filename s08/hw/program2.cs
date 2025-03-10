// namespace hw
// {
//     class Program2
//     {
//         static void reverse(string s1, out string sout)
//         {
//             sout = "";
//             foreach (char c in s1)
//             {
//                 sout = c + sout;
//             }
//         }

//         static void reverse_whole_sen(string sen, out string senout)
//         {
//             reverse(sen, out senout);
//         }

//         static void cut(string s, out string sout, int begin, int end)
//         {
//             sout = s.Substring(begin, end - begin + 1);
//         }

//         static void split(string s, out string[] sout)
//         {
//             int n = count_words(s);
//             sout = new string[n];
//             int j = 0, wordIndex = 0;

//             for (int i = 0; i < s.Length; i++)
//             {
//                 if (s[i] == ' ' || i == s.Length - 1)
//                 {
//                     int end = (s[i] == ' ') ? i - 1 : i;
//                     cut(s, out sout[wordIndex], j, end);
//                     wordIndex++;
//                     j = i + 1;
//                 }
//             }
//         }

//         static int count_words(string sen)
//         {
//             int j = 1;
//             for (int i = 0; i < sen.Length; i++)
//             {
//                 if (sen[i] == ' ') j++;
//             }
//             return j;
//         }

//         static void reverse_sen(string sen, out string senout)
//         {
//             int n = count_words(sen);
//             string[] sen_split;
//             split(sen, out sen_split);
//             senout = "";

//             for (int i = n - 1; i >= 0; i--)
//             {
//                 senout += sen_split[i];
//                 if (i != 0) senout += " ";
//             }
//         }

//         static void Main(string[] args)
//         {
//             string s1 = "I love coding";
//             string s2;
//             reverse_sen(s1, out s2);
//             System.Console.WriteLine(s2);
//         }
//     }
// }
