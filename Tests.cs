using Xunit;
using MyUtilities;
    public class Tests{
    
   [Fact]
  /* public void PassingPowerTest(){
    
    Assert.Equal(3, MathUtils.Power(9,.5));
   }*/
   public void FracTest(){
    Fraction f = Fraction.RealToFraction(.5,.00001);
    Assert.Equal(2, f.getDenominator());
   }

[Fact]
   public void intPowTest(){
    Assert.Equal(27,MathUtils.Power(3,3));
   }
    }