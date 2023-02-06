namespace MyUtilities
{
    public static class ArrayUtils
    {
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




        public static int Add(int[] i){
            int b = 0;
            foreach(int d in i){
                b += d;
            }
            return b;
        }
        public static double Add(double[] i){
            double b = 0;
            foreach(double d in i){
                b += d;
            }
            return b;
        }
        public static decimal Add(decimal[] i){
            decimal b = 0;
            foreach(decimal d in i){
                b += d;
            }
            return b;
        }
        public static float Add(float[] i){
            float b = 0;
            foreach(float d in i){
                b += d;
            }
            return b;
        }
        public static long Add(long[] i){
            long b = 0;
            foreach(long d in i){
                b += d;
            }
            return b;
        }




        public static int Product(int[] i){
            int b = 0;
            foreach(int d in i){
                b += d;
            }
            return b;
        }
        public static double Product(double[] i){
            double b = 0;
            foreach(double d in i){
                b += d;
            }
            return b;
        }
        public static decimal Product(decimal[] i){
            decimal b = 0;
            foreach(decimal d in i){
                b += d;
            }
            return b;
        }
        public static float Product(float[] i){
            float b = 0;
            foreach(float d in i){
                b += d;
            }
            return b;
        }
        public static long Product(long[] i){
            long b = 0;
            foreach(long d in i){
                b += d;
            }
            return b;
        }
    }
}