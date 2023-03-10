namespace MyUtilities
{


    public static class MathUtils
    {

        ///<summary>
        ///returns the nth root of a number (double)
        ///</summary> 
        ///
        ///<param name="A"> double
        ///<param name="N"> int
        ///<returns>
        ///the nth root of A
        ///</returns> 
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
                //returns the nth root of a number 

        public static double NthRoot(long A, int N)
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
                //returns the nth root of a number 

        public static decimal NthRoot(decimal A, int N)
        {
            return NthRoot(A, N);
        }

                //returns the nth root of a number 
        public static double NthRoot(int n, int N)
        {
            int x = n;
            int y = 1;
            while (x > y) {
                x = (x + y) / 2;
                y = n / x;
            }
            return (uint)x;
            }
                   
             //returns the nth root of a number 
            public static float NthRoot(float A, int N)
            {
                return NthRoot(A, N);
            }

        ///<summary>
        ///returns the absolute value of a number
        ///</summary> 
        ///
        ///<param name="n"> double
        ///<returns>
        ///the absolute value
        ///</returns> 
        public static double AbsoluteValue(double n)
        {
            if (n < 0)
            {
                return (n * (-1));
            }
            return n;
        }
                //returns the absolute value of a number

        public static int AbsoluteValue(int n)
        {
            if (n < 0)
            {
                return (n * (-1));
            }
            return n;
        }
                //returns the absolute value of a number

        public static double AbsoluteValue(float n)
        {
            return AbsoluteValue(n);
        }
                //returns the absolute value of a number

        public static double AbsoluteValue(decimal n)
        {
            return AbsoluteValue(n);
        }
                //returns the absolute value of a number

        public static double AbsoluteValue(long n)
        {
            return AbsoluteValue(n);
        }


        ///<summary>
        ///returns num to the power of exponent
        ///</summary> 
        ///
        ///<param name="num"> double
        ///<param name="exponent"> double
        ///<returns>
        ///num to the power of exponent
        ///</returns> 
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
            }else if (exponent < 0)
            {
                ans2 = 1 / operation(num, exponent);
                return (ans2);
            }else if (exponent < 1)
            {
                Fraction x = Fraction.RealToFraction(exponent, .01);
                int numerator = x.getNumerator();
                int denominator = x.getDenominator();
                double z = operation(num, numerator);
                return (NthRoot(z, denominator));

            }else
            {
                ans = operation(num, exponent);
                return (ans);
            }
        }

//returns the value of num to the exponent
        public static int Power(int num, int exponent)
        {
                int count = 1;
                int rvalue = num;
                while (count < exponent)
                {
                    rvalue *= num;
                    count++;
                }
                return rvalue;
        }

//returns the value of num to the exponent
        public static float Power(float num, float exponent)
        {
            float operation(float num, float exponent)
            {
                int count = 1;
                float rvalue = num;
                while (count < exponent)
                {
                    rvalue *= num;
                    count++;
                }
                return rvalue;
            }


            float ans;
            float ans2;
            if (exponent == 0)
            {
                return (1);
            }else if (exponent < 0)
            {
                ans2 = 1 / operation(num, exponent);
                return (ans2);
            }else if (exponent < 1)
            {
                Fraction x = Fraction.RealToFraction(exponent, .01);
                int numerator = x.getNumerator();
                int denominator = x.getDenominator();
                float z = operation(num, numerator);
                return (NthRoot(z, denominator));

            }else
            {
                ans = operation(num, exponent);
                return (ans);
            }
        }
        //returns the value of num to the exponent

        public static double Power(long num, long exponent)
        {
            long operation(long num, long exponent)
            {
                int count = 1;
                long rvalue = num;
                while (count < exponent)
                {
                    rvalue *= num;
                    count++;
                }
                return rvalue;
            }


            long ans;
            long ans2;
            if (exponent == 0)
            {
                return (1);
            }else if (exponent < 0)
            {
                ans2 = 1 / operation(num, exponent);
                return (ans2);
            }else if (exponent < 1)
            {
                Fraction x = Fraction.RealToFraction(exponent, .01);
                int numerator = x.getNumerator();
                int denominator = x.getDenominator();
                long z = operation(num, numerator);
                return (NthRoot(z, denominator));

            }else
            {
                ans = operation(num, exponent);
                return (ans);
            }
        }

//returns the value of num to the exponent
        public static decimal Power(decimal num, decimal exponent)
        {
            return MathUtils.Power(num, exponent);
        }



        ///<summary>
        ///compares two inputted values and returns the smaller of the two
        ///</summary> 
        ///
        ///<param name="y"> int
        ///<param name="x"> int
        ///<returns>
        ///the smaller value
        ///</returns> 
        public static int Min(int y, int x){
            if(x > y){
                return y;
            }else{
                return x;
            }
        }
        ///compares two inputted values and returns the smaller of the two
        public static decimal Min(decimal y, decimal x){
            if(x > y){
                return y;
            }else{
                return x;
            }
        }
        ///compares two inputted values and returns the smaller of the two
        public static double Min(double y, double x){
            if(x > y){
                return y;
            }else{
                return x;
            }
        }
        ///compares two inputted values and returns the smaller of the two
        public static float Min(float y, float x){
            if(x > y){
                return y;
            }else{
                return x;
            }
        }
        ///compares two inputted values and returns the smaller of the two
        public static long Min(long y, long x){
            if(x > y){
                return y;
            }else{
                return x;
            }
        }


        ///<summary>
        ///compares two inputted values and returns the larger of the two
        ///</summary> 
        ///
        ///<param name="y"> int
        ///<param name="x"> int
        ///<returns>
        ///the larger value
        ///</returns> 
        public static int Max(int y, int x){
            if(x > y){
                return x;
            }else{
                return y;
            }
        }
        ///compares two inputted values and returns the larger of the two
        public static float Max(float y, float x){
            if(x > y){
                return x;
            }else{
                return y;
            }
        }
        ///compares two inputted values and returns the larger of the two
        public static decimal Max(decimal y, decimal x){
            if(x > y){
                return x;
            }else{
                return y;
            }
        }
        ///compares two inputted values and returns the larger of the two
        public static double Max(double y, double x){
            if(x > y){
                return x;
            }else{
                return y;
            }
        }
        ///compares two inputted values and returns the larger of the two
        public static long Max(long y, long x){
            if(x > y){
                return x;
            }else{
                return y;
            }
        }

        ///<summary>
        ///adds together two inputted integers
        ///</summary> 
        ///
        ///<param name="y"> int
        ///<param name="x"> int
        ///<returns>
        ///the sum of x and y
        ///</returns> 
        public static int Add(int y, int x){
            return x + y;
        }
                // returns the sum of x and y

        public static decimal Add(decimal y, decimal x){
            return x + y;
        }
                // returns the sum of x and y

        public static double Add(double y, double x){
            return x + y;
        }
                // returns the sum of x and y

        public static float Add(float y, float x){
            return x + y;
        }
                // returns the sum of x and y

        public static long Add(long y, long x){
            return x + y;
        }


        ///<summary>
        ///subtracts x from y
        ///</summary> 
        ///
        ///<param name="y"> int
        ///<param name="x"> int
        ///<returns>
        ///y-x
        ///</returns> 
        public static int Subtract(int y, int x){
            return y - x;
        }
         // returns the value of y-x
        public static decimal Subtract(decimal y, decimal x){
            return y - x;
        }
         // returns the value of y-x
        public static double Subtract(double y, double x){
            return y - x;
        }
         // returns the value of y-x
        public static float Subtract(float y, float x){
            return y - x;
        }
         // returns the value of y-x
        public static long Subtract(long y, long x){
            return y - x;
        }

        ///<summary>
        ///divides x by y
        ///</summary> 
        ///
        ///<param name="y"> int
        ///<param name="x"> int
        ///<returns>
        ///y/x
        ///</returns> 
        public static double Divide(int y, int x){
            return y / x;
        }
        //returns the value of y/x

        public static double Divide(float y, float x){
            return y / x;
        }
        //returns the value of y/x

        public static decimal Divide(decimal y, decimal x){
            return y / x;
        }
        //returns the value of y/x

        public static double Divide(double y, double x){
            return y / x;
        }
        //returns the value of y/x

        public static double Divide(long y, long x){
            return y / x;
        }

        ///<summary>
        ///multiplies together two inputted integers
        ///</summary> 
        ///
        ///<param name="y"> int
        ///<param name="x"> int
        ///<returns>
        ///the product of x and y
        ///</returns> 
        public static int Multiply(int y, int x){
            return x * y;
        }
                //returns the product of y and x

        public static decimal Multiply(decimal y, decimal x){
            return x * y;
        }
        //returns the product of y and x
        public static double Multiply(double y, double x){
            return x * y;
        }
                //returns the product of y and x

        public static long Multiply(long y, long x){
            return x * y;
        }
                //returns the product of y and x

        public static float Multiply(float y, float x){
            return x * y;
        }
    }
}