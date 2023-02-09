using MyUtilities;
public class runner


///<summary>
///
///</summary> 
///
///<param name="">
///<returns>
///
 ///</returns>
{

    public static void Main(string[] args)
    {
        int[] i = {2,4,1,5,3};
        Console.WriteLine(MathUtils.Power(3,3));
        Console.WriteLine(MathUtils.Power(9,.5));
        Console.WriteLine(MathUtils.Power(5.0,-1));
        Console.WriteLine(StringUtils.ToUpper("banana"));
        Console.WriteLine(StringUtils.ToLower("BANANA"));
        Console.WriteLine(StringUtils.Length("bababa"));
        Console.WriteLine(StringUtils.Reverse("Mark Gorman"));
        Console.WriteLine(StringUtils.CountVowels("akelihonuuuubbuu"));
        Console.WriteLine(StringUtils.CountConsonants("akelihonuuuubbuu"));
        Console.WriteLine(ArrayUtils.Average(i));
        Console.WriteLine(ArrayUtils.Max(i));
        Console.WriteLine(ArrayUtils.Min(i));
        int[] b = ArrayUtils.SortAscending(i);
        foreach(int g in b){
            Console.Write(g + ", ");            
        }
        Console.WriteLine();
        int[] o = ArrayUtils.SortDescending(i);
        foreach(int h in o){
            Console.Write(h + ", ");            
        }
        Console.WriteLine();
        Console.WriteLine(ArrayUtils.Add(i));
        Console.WriteLine(ArrayUtils.Product(i));
        Console.WriteLine(MathUtils.Power(3.4f,3.6f));
    }}