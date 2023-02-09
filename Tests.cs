using Xunit;
using MyUtilities;
public class Tests
{

    [Fact]
    /* public void PassingPowerTest(){

      Assert.Equal(3, MathUtils.Power(9,.5));
     }*/
    public void FracTest()
    {
        Fraction f = Fraction.RealToFraction(.5, .00001);
        Assert.Equal(2, f.getDenominator());
    }

    [Fact]
    public void intPowTest()
    {
        Assert.Equal(27, MathUtils.Power(3, 3));
    }
    [Fact]
    public void rootTest()
    {
      Assert.Equal(3, MathUtils.NthRoot(9, 2));
    }
    [Fact]
    public void addTest()
    {
      Assert.Equal(12, MathUtils.Add(7, 5));
    }
    [Fact]
    public void divideTest()
    {
      Assert.Equal(6, MathUtils.Divide(18, 3));
    }
    [Fact]
    public void multiplyTest()
    {
      Assert.Equal(42, MathUtils.Multiply(10.5f, 4));
    }
    [Fact]
    public void subtractTest()
    {
      Assert.Equal(9, MathUtils.Subtract(32.68f, 23.68f));
    }
    [Fact]
    public void absoluteTest()
    {
      Assert.Equal(49, MathUtils.AbsoluteValue(-49));
    }
    [Fact]
    public void minTest()
    {
      Assert.Equal(3, MathUtils.Min(8, 3));
    }
    [Fact]
    public void maxTest()
    {
      Assert.Equal(8, MathUtils.Max(8, 3));
    }


    [Fact]
    public void upperTest()
    {
      Assert.Equal("GEORGE", StringUtils.ToUpper("gEorGE"));
    }
    [Fact]
    public void lowerTest()
    {
      Assert.Equal("george", StringUtils.ToLower("gEorGE"));
    }
    [Fact]
    public void lengthTest()
    {
      Assert.Equal(14, StringUtils.Length("peanut butter!"));
    }
    [Fact]
    public void reverseTest()
    {
      Assert.Equal("EGroEg", StringUtils.Reverse("gEorGE"));
    }
    [Fact]
    public void vowelTest()
    {
      Assert.Equal(5, StringUtils.CountVowels("peanut butter!"));
    }
    [Fact]
    public void consonantTest()
    {
      Assert.Equal(9, StringUtils.CountConsonants("peanut butter!"));
    }



    int[] i = {3,5,2,1,4};
    [Fact]
    public void averageTest()
    {
      Assert.Equal(3, ArrayUtils.Average(i));
    }
    [Fact]
    public void maxTest2()
    {
      Assert.Equal(5, ArrayUtils.Max(i));
    }
    [Fact]
    public void minTest2()
    {
      Assert.Equal(1, ArrayUtils.Min(i));
    }
    int[] a = {1,2,3,4,5};
    [Fact]
    public void ascendingTest()
    {
      Assert.Equal(a, ArrayUtils.SortAscending(i));
    }
    int[] d = {5,4,3,2,1};
    [Fact]
    public void descendingTest()
    {
      Assert.Equal(d, ArrayUtils.SortDescending(i));
    }
    [Fact]
    public void addTest2()
    {
      Assert.Equal(15, ArrayUtils.Add(i));
    }
    [Fact]
    public void productTest()
    {
      Assert.Equal(120, ArrayUtils.Product(i));
    }
}
