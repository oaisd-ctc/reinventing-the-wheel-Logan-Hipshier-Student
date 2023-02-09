namespace MyUtilities{
    public static class StringUtils{

        //Converts inputted string to upper case ie: hello -> HELLO

        ///<summary>
///Converts inputted string to upper case ie: hello -> HELLO
///</summary> 
///
///<param name="input"> string
///<returns>
/// converted string 
 ///</returns>
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

        //   

///<summary>
///converts inputted string to lower case ie: HELLO -> hello 
///</summary> 
///
///<param name="input"> string
///<returns>
/// converted string 
 ///</returns>

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

        //
        ///<summary>
///Returns the length of inputted string as an int
///</summary> 
///
///<param name="s"> string
///<returns>
/// length of the string
 ///</returns>
        public static int Length(string s){
            int i = 0;
            foreach(char a in s){
                i++;
            }
            return i;
        }

///<summary>
/////Reverses inputted string ie: Hello -> olleH
///</summary> 
///
///<param name="s"> reversed string
///<returns>
/// reversed string
 ///</returns>
        
        public static string Reverse(string s){
            int i = StringUtils.Length(s)-1;
            string s2 = "";
            foreach(char a in s){
                s2 += s[i];
                i--;
            }
            return s2;
        }

///<summary>
///Returns the number of vowels in a string as an int
///</summary> 
///
///<param name="s"> string
///<returns>
/// number of vowels 
 ///</returns>
        //
        public static int CountVowels(string s){
            int i = 0;
            foreach(char a in s){
                if(a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u'){
                    i++;
                }
            }
            return i;
        }

        //
        ///<summary>
///Returns the number of consonants in a string as an int
///</summary> 
///
///<param name="s"> string
///<returns>
/// number of consonants
 ///</returns>
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