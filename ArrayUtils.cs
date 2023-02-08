namespace MyUtilities
{
    public static class ArrayUtils
    {
        //returns the average of all values in an array (int)
        /// <summary>
        ///Returns the average of all values in the array
        ///</summary
        ///<param name="i"> The array
        ///<returns>
        ///The resulting array
        ///</returns>
        public static int Average(int[] i)
        {
            int f = 0;
            int count = 0;
            foreach (int b in i)
            {
                f += b;
                count++;
            }
            f /= count;
            return f;
        }
        //returns the average of all values in an array (decimal)
        public static decimal Average(decimal[] i)
        {
            decimal f = 0;
            int count = 0;
            foreach (decimal b in i)
            {
                f += b;
                count++;
            }
            f /= count;
            return f;
        }
        //returns the average of all values in an array (decimal)
        public static float Average(float[] i)
        {
            float f = 0;
            int count = 0;
            foreach (float b in i)
            {
                f += b;
                count++;
            }
            f /= count;
            return f;
        }
        //returns the average of all values in an array (long)
        public static long Average(long[] i)
        {
            long f = 0;
            int count = 0;
            foreach (long b in i)
            {
                f += b;
                count++;
            }
            f /= count;
            return f;
        }
        
        //returns all the average of all values in an array (double)
        public static double Average(double[] i)
        {
            double f = 0;
            int count = 0;
            foreach (double b in i)
            {
                f += b;
                count++;
            }
            f /= count;
            return f;
        }


        //returns the largest value in an array (int)
        ///<summary>
        /// returns the largest value in the array
        ///</summary>
        ///<param name="i" array
        ///<returns>
        ///the largest value in the array
        ///</returns>
        public static int Max(int[] i)
        {
            int max = i[0];
            foreach (int b in i)
            {
                if (b > max)
                {
                    max = b;
                }
            }
            return max;
        }
        // returns the largest value in an array (decimal)
        public static decimal Max(decimal[] i)
        {
            decimal max = i[0];
            foreach (decimal b in i)
            {
                if (b > max)
                {
                    max = b;
                }
            }
            return max;
        }
        //returns the largest value in an array(double)
        public static double Max(double[] i)
        {
            double max = i[0];
            foreach (double b in i)
            {
                if (b > max)
                {
                    max = b;
                }
            }
            return max;
        }
        //returns the largest value in an array (float)
        public static float Max(float[] i)
        {
            float max = i[0];
            foreach (float b in i)
            {
                if (b > max)
                {
                    max = b;
                }
            }
            return max;
        }
                //returns the largest value in an array (long)
        public static long Max(long[] i)
        {
            long max = i[0];
            foreach (long b in i)
            {
                if (b > max)
                {
                    max = b;
                }
            }
            return max;
        }

        //returns the smallest value in an array (int)
        ///<summary>
        ///returns the smallest value in an array
        ///</summary>
        ///<param name="i"> array
        ///<returns>
        ///the smallest value in the array
        ///</returns>


        

        public static int Min(int[] i)
        {
            int min = i[0];
            foreach (int b in i)
            {
                if (b < min)
                {
                    min = b;
                }
            }
            return min;
        }
        //returns the smallest value in an array (decimal)
        public static decimal Min(decimal[] i)
        {
            decimal min = i[0];
            foreach (decimal b in i)
            {
                if (b < min)
                {
                    min = b;
                }
            }
            return min;
        }
        //returns the smallest value in an array (double)
        public static double Min(double[] i)
        {
            double min = i[0];
            foreach (double b in i)
            {
                if (b < min)
                {
                    min = b;
                }
            }
            return min;
        }
        //returns the smallest value in an array (float)
        public static float Min(float[] i)
        {
            float min = i[0];
            foreach (float b in i)
            {
                if (b < min)
                {
                    min = b;
                }
            }
            return min;
        }
        //returns the smallest value in an array (long)
        public static long Min(long[] i)
        {
            long min = i[0];
            foreach (long b in i)
            {
                if (b < min)
                {
                    min = b;
                }
            }
            return min;
        }


        //sorts the array into ascending order (int)
        public static int[] SortAscending(int[] i)
        {
            int count = 0;
            foreach(int h in i)
            {
                count++;
            }
            int[] sort = new int[count];
            int temp = 0;
            for (int b = 0; b <= count - 1; b++)
            {
                for (int j = b + 1; j < count; j++)
                {
                    if (i[b] > i[j])
                    {
                        temp = i[b];
                        i[b] = i[j];
                        i[j] = temp;
                    }
                }
            }
            int t = 0;
            foreach (int g in i)
            {
                sort[t] = g;
                t++;
            }
            return i;
        }
           //sorts the array into ascending order (double)
        public static double[] SortAscending(double[] i)
        {
            int count = 0;
            foreach(double h in i)
            {
                count++;
            }
            double[] sort = new double[count];
            double temp = 0;
            for (int b = 0; b <= count - 1; b++)
            {
                for (int j = b + 1; j < count; j++)
                {
                    if (i[b] > i[j])
                    {
                        temp = i[b];
                        i[b] = i[j];
                        i[j] = temp;
                    }
                }
            }
            int t = 0;
            foreach (double g in i)
            {
                sort[t] = g;
                t++;
            }
            return i;
        }
           //sorts the array into ascending order (decimal)
        public static decimal[] SortAscending(decimal[] i)
        {
            int count = 0;
            foreach(decimal h in i)
            {
                count++;
            }
            decimal[] sort = new decimal[count];
            decimal temp = 0;
            for (int b = 0; b <= count - 1; b++)
            {
                for (int j = b + 1; j < count; j++)
                {
                    if (i[b] > i[j])
                    {
                        temp = i[b];
                        i[b] = i[j];
                        i[j] = temp;
                    }
                }
            }
            int t = 0;
            foreach (decimal g in i)
            {
                sort[t] = g;
                t++;
            }
            return i;
        }
           //sorts the array into ascending order (float)
        public static float[] SortAscending(float[] i)
        {
            int count = 0;
            foreach(float h in i)
            {
                count++;
            }
            float[] sort = new float[count];
            float temp = 0;
            for (int b = 0; b <= count - 1; b++)
            {
                for (int j = b + 1; j < count; j++)
                {
                    if (i[b] > i[j])
                    {
                        temp = i[b];
                        i[b] = i[j];
                        i[j] = temp;
                    }
                }
            }
            int t = 0;
            foreach (float g in i)
            {
                sort[t] = g;
                t++;
            }
            return i;
        }
           //sorts the array into ascending order (long)
        public static long[] SortAscending(long[] i)
        {
            int count = 0;
            foreach(long h in i)
            {
                count++;
            }
            long[] sort = new long[count];
            long temp = 0;
            for (int b = 0; b <= count - 1; b++)
            {
                for (int j = b + 1; j < count; j++)
                {
                    if (i[b] > i[j])
                    {
                        temp = i[b];
                        i[b] = i[j];
                        i[j] = temp;
                    }
                }
            }
            int t = 0;
            foreach (long g in i)
            {
                sort[t] = g;
                t++;
            }
            return i;
        }



        // sorts the array into descending order (int)
        public static int[] SortDescending(int[] i)
        {
            int count = 0;
            foreach(int h in i)
            {
                count++;
            }
            int[] sort = new int[count];
            int temp = 0;
            for (int b = 0; b <= count - 1; b++)
            {
                for (int j = b + 1; j < count; j++)
                {
                    if (i[b] < i[j])
                    {
                        temp = i[b];
                        i[b] = i[j];
                        i[j] = temp;
                    }
                }
            }
            int t = 0;
            foreach (int g in i)
            {
                sort[t] = g;
                t++;
            }
            return i;
        }
        // sorts the array into descending order (double)
        public static double[] SortDescending(double[] i)
        {
            int count = 0;
            foreach(double h in i)
            {
                count++;
            }
            double[] sort = new double[count];
            double temp = 0;
            for (int b = 0; b <= count - 1; b++)
            {
                for (int j = b + 1; j < count; j++)
                {
                    if (i[b] < i[j])
                    {
                        temp = i[b];
                        i[b] = i[j];
                        i[j] = temp;
                    }
                }
            }
            int t = 0;
            foreach (double g in i)
            {
                sort[t] = g;
                t++;
            }
            return i;
        }
        // sorts the array into descending order (decimal)
        public static decimal[] SortDescending(decimal[] i)
        {
            int count = 0;
            foreach(decimal h in i)
            {
                count++;
            }
            decimal[] sort = new decimal[count];
            decimal temp = 0;
            for (int b = 0; b <= count - 1; b++)
            {
                for (int j = b + 1; j < count; j++)
                {
                    if (i[b] < i[j])
                    {
                        temp = i[b];
                        i[b] = i[j];
                        i[j] = temp;
                    }
                }
            }
            int t = 0;
            foreach (decimal g in i)
            {
                sort[t] = g;
                t++;
            }
            return i;
        }
        // sorts the array into descending order (float)
        public static float[] SortDescending(float[] i)
        {
            int count = 0;
            foreach(float h in i)
            {
                count++;
            }
            float[] sort = new float[count];
            float temp = 0;
            for (int b = 0; b <= count - 1; b++)
            {
                for (int j = b + 1; j < count; j++)
                {
                    if (i[b] < i[j])
                    {
                        temp = i[b];
                        i[b] = i[j];
                        i[j] = temp;
                    }
                }
            }
            int t = 0;
            foreach (float g in i)
            {
                sort[t] = g;
                t++;
            }
            return i;
        }
        // sorts the array into descending order (long)
        public static long[] SortDescending(long[] i)
        {
            int count = 0;
            foreach(long h in i)
            {
                count++;
            }
            long[] sort = new long[count];
            long temp = 0;
            for (int b = 0; b <= count - 1; b++)
            {
                for (int j = b + 1; j < count; j++)
                {
                    if (i[b] < i[j])
                    {
                        temp = i[b];
                        i[b] = i[j];
                        i[j] = temp;
                    }
                }
            }
            int t = 0;
            foreach (long g in i)
            {
                sort[t] = g;
                t++;
            }
            return i;
        }



        // adds a value to the array (int)
        public static int Add(int[] i){
            int b = 0;
            foreach(int d in i){
                b += d;
            }
            return b;
        }
            // adds a value to the array(double)
        public static double Add(double[] i){
            double b = 0;
            foreach(double d in i){
                b += d;
            }
            return b;
        }
            // adds a value to the array (decimal)
        public static decimal Add(decimal[] i){
            decimal b = 0;
            foreach(decimal d in i){
                b += d;
            }
            return b;
        }
            // adds a value to the array(float)
        public static float Add(float[] i){
            float b = 0;
            foreach(float d in i){
                b += d;
            }
            return b;
        }
            // adds a value to the array (long)
        public static long Add(long[] i){
            long b = 0;
            foreach(long d in i){
                b += d;
            }
            return b;
        }



        // multiplies each value in the array by i (int)
        public static int Product(int[] i){
            int b = 1;
            foreach(int d in i){
                b *= d;
            }
            return b;
        }
         // multiplies each value in the array by i (double)
        public static double Product(double[] i){
            double b = 1;
            foreach(double d in i){
                b *= d;
            }
            return b;
        }
         // multiplies each value in the array by i(decimal)
        public static decimal Product(decimal[] i){
            decimal b = 1;
            foreach(decimal d in i){
                b *= d;
            }
            return b;
        }
         // multiplies each value in the array by i (float)
        public static float Product(float[] i){
            float b = 1;
            foreach(float d in i){
                b *= d;
            }
            return b;
        }
         // multiplies each value in the array by i (long)
        public static long Product(long[] i){
            long b = 1;
            foreach(long d in i){
                b *= d;
            }
            return b;
        }
    }
}