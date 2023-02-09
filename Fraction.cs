namespace MyUtilities{

public class Fraction{
private int N;
private int D;
    public Fraction(int n, int d){
        N =n;
         D=d;


    }
public int getNumerator(){
    return N;
}
public int getDenominator(){
    return D;
}





public static Fraction RealToFraction(double value, double accuracy)
{
    if (accuracy <= 0.0 || accuracy >= 1.0)
    {
        throw new ArgumentOutOfRangeException("accuracy", "Must be > 0 and < 1.");
    }

    int sign;

    if (value <0){
        sign=-1;
    }
    else if(value==0){
        sign =0;
    }
    else{
        sign = 1;
    }

    if (sign == -1)
    {
        value = (-1) * value;
    }
        int Floor(double val){
            if (val>0){
                return((int)val);
            }
            else if(val==0){
                return 0;
            }
            else{
                return((int)(val-1));
            }

        }
    // Accuracy is the maximum relative error; convert to absolute maxError
    double maxError = sign == 0 ? accuracy : value * accuracy;

    int n = (int) Floor(value);
    value -= n;

    if (value < maxError)
    {
        return new Fraction(sign * n, 1);
    }

    if (1 - maxError < value)
    {
        return new Fraction(sign * (n + 1), 1);
    }

    // The lower fraction is 0/1
    int lower_n = 0;
    int lower_d = 1;

    // The upper fraction is 1/1
    int upper_n = 1;
    int upper_d = 1;

    while (true)
    {
        // The middle fraction is (lower_n + upper_n) / (lower_d + upper_d)
        int middle_n = lower_n + upper_n;
        int middle_d = lower_d + upper_d;

        if (middle_d * (value + maxError) < middle_n)
        {
            // real + error < middle : middle is our new upper
            upper_n = middle_n;
            upper_d = middle_d;
        }
        else if (middle_n < (value - maxError) * middle_d)
        {
            // middle < real - error : middle is our new lower
            lower_n = middle_n;
            lower_d = middle_d;
        }
        else
        {
            // Middle is our best fraction
            return new Fraction((n * middle_d + middle_n) * sign, middle_d);
        }
    }
}

}







}