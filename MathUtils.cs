namespace MyUtilities
{


    public static class MathUtils
    {

        public static double NthRoot(double A, int N)
        {
            double epsilon = 0.00001d;//
            double n = N;
            double x = A / n;
            while (Math.Abs(A - Power(x, N)) > epsilon)
            {
                x = (1.0d / n) * ((n - 1) * x + (A / (Power(x, N - 1))));
            }
            return x;
        }
        public static double NthRoot(long A, int N)
        {
            return NthRoot(A, N);
        }
        public static double NthRoot(decimal A, int N)
        {
            return NthRoot(A, N);
        }
        public static double NthRoot(int A, int N)
        {
            return NthRoot(A, N);
        }
        public static double NthRoot(float A, int N)
        {
            return NthRoot(A, N);
        }


        public static double AbsoluteValue(double n)
        {
            if (n < 0)
            {
                return (n * (-1));
            }
            return n;
        }
        public static double AbsoluteValue(int n)
        {
            return AbsoluteValue(n);
        }
        public static double AbsoluteValue(float n)
        {
            return AbsoluteValue(n);
        }
        public static double AbsoluteValue(decimal n)
        {
            return AbsoluteValue(n);
        }
        public static double AbsoluteValue(long n)
        {
            return AbsoluteValue(n);
        }


        public static double Power(double num, double exponent)
        {

            double operation(double num, double exponent)
            {
                int count = 1;
                double rvalue = num;
                while (count < exponent)
                {
                    rvalue *= num;
                    count++;
                }
                return rvalue;
            }


            double ans;
            double ans2;
            if (exponent == 0)
            {
                return (1);
            }
            else if (exponent < 0)
            {
                ans2 = 1 / operation(num, exponent);
                return (ans2);
            }
            else if (exponent < 1)
            {
                Fraction x = Fraction.RealToFraction(exponent, .01);
                int numerator = x.getNumerator();
                int denominator = x.getDenominator();
                double z = operation(num, numerator);
                return (NthRoot(z, denominator));

            }


            else
            {
                ans = operation(num, exponent);
                return (ans);
            }
        }

        public static int Power(int num, int exponent)
        {
            return MathUtils.Power(num, exponent);
        }

        public static float Power(float num, int exponent)
        {
            return MathUtils.Power(num, exponent);
        }

        public static long Power(long num, int exponent)
        {
            return MathUtils.Power(num, exponent);
        }

        public static decimal Power(decimal num, int exponent)
        {
            return MathUtils.Power(num, exponent);
        }



        public static int Min(int y, int x){
            if(x > y){
                return y;
            }else{
                return x;
            }
        }
        public static decimal Min(decimal y, decimal x){
            if(x > y){
                return y;
            }else{
                return x;
            }
        }
        public static double Min(double y, double x){
            if(x > y){
                return y;
            }else{
                return x;
            }
        }
        public static float Min(float y, float x){
            if(x > y){
                return y;
            }else{
                return x;
            }
        }
        public static long Min(long y, long x){
            if(x > y){
                return y;
            }else{
                return x;
            }
        }


        public static int Max(int y, int x){
            if(x > y){
                return x;
            }else{
                return y;
            }
        }
        public static float Max(float y, float x){
            if(x > y){
                return x;
            }else{
                return y;
            }
        }
        public static decimal Max(decimal y, decimal x){
            if(x > y){
                return x;
            }else{
                return y;
            }
        }
        public static double Max(double y, double x){
            if(x > y){
                return x;
            }else{
                return y;
            }
        }
        public static long Max(long y, long x){
            if(x > y){
                return x;
            }else{
                return y;
            }
        }


        public static int Add(int y, int x){
            return x + y;
        }
        public static decimal Add(decimal y, decimal x){
            return x + y;
        }
        public static double Add(double y, double x){
            return x + y;
        }
        public static float Add(float y, float x){
            return x + y;
        }
        public static long Add(long y, long x){
            return x + y;
        }


        public static int Subtract(int y, int x){
            return y - x;
        }
        public static decimal Subtract(decimal y, decimal x){
            return y - x;
        }
        public static double Subtract(double y, double x){
            return y - x;
        }
        public static float Subtract(float y, float x){
            return y - x;
        }
        public static long Subtract(long y, long x){
            return y - x;
        }


        public static double Divide(int y, int x){
            return y - x;
        }
        public static double Divide(float y, float x){
            return y - x;
        }
        public static decimal Divide(decimal y, decimal x){
            return y - x;
        }
        public static double Divide(double y, double x){
            return y - x;
        }
        public static double Divide(long y, long x){
            return y - x;
        }


        public static int Multiply(int y, int x){
            return x * y;
        }
        public static decimal Multiply(decimal y, decimal x){
            return x * y;
        }
        public static double Multiply(double y, double x){
            return x * y;
        }
        public static long Multiply(long y, long x){
            return x * y;
        }
        public static float Multiply(float y, float x){
            return x * y;
        }
    }
}