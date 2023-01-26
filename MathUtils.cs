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
        public static double AbsoluteValue(double n)
        {
            if (n < 0)
            {
                return (n * (-1));
            }
            return n;
        }


        public static int Power(int num, int exponent)
        {
            int operation(int num, int exponent)
            {
                int count = 1;
                int rvalue = num;
                while (count < exponent)
                {
                    rvalue *= num;

                    count++;
                }
                return (rvalue);
            }


            int ans;
            double ans2;
            if (exponent == 0)
            {

                return (1);
            }
            else if (exponent < 0)
            {
                Console.WriteLine("<0");
                ans2 = 1 / operation(num, exponent);

                return ((int)ans2);
            }
            else
            {

                ans = operation(num, exponent);

                return (ans);
            }
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









    }
}