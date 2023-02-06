namespace MyUtilities{
    public static class StringUtils{
        public static String ToUpper(String input)
        {
           String output = "";
           for (int i = 0; i < input.Length; i++)
           {
              if (input[i] >= 'a' && input[i] <= 'z')
              {
                 output += (char)(input[i] - 'a' + 'A');
              }
              else
              {
                 output += input[i];
              }
           }
           return output;
        }

        public static String ToLower(String input)
        {
           String output = "";
           for (int i = 0; i < input.Length; i++)
           {
              if (input[i] >= 'A' && input[i] <= 'Z')
              {
                 output += (char)(input[i] - 'A' + 'a');
              }
              else
              {
                 output += input[i];
              }
           }
           return output;
        }

        public static int Length(string s){
            int i = 0;
            foreach(char a in s){
                i++;
            }
            return i;
        }

        public static string Reverse(string s){
            int i = StringUtils.Length(s)-1;
            string s2 = "";
            foreach(char a in s){
                s2 += s[i];
                i--;
            }
            return s2;
        }

        public static int CountVowels(string s){
            int i = 0;
            foreach(char a in s){
                if(a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u'){
                    i++;
                }
            }
            return i;
        }

        public static int CountConsonants(string s){
            int i = 0;
            foreach(char a in s){
                if(a != 'a' && a != 'e' && a != 'i' && a != 'o' && a != 'u'){
                    i++;
                }
            }
            return i;
        }
    }
}