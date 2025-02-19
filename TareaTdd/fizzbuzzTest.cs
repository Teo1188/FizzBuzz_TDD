namespace TareaTdd
{
    public class fizzbuzzTest
    {
    [Theory]
    [InlineData(1,"1")]
    [InlineData(2,"2")]

    public void NumbersWithNoSpecialPropertiesReturnTheNumber(int input, string expectedResult)
         {
         var actualResult = FizzBuzz.GetFizzBuzzString(input);
         Assert.Equal(expectedResult, actualResult);
         }


    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    

        public void NumbersDivisibleByThreeButNotFiveReturnFizz(int input)
        {
            var actualResult = FizzBuzz.GetFizzBuzzString(input);
            Assert.Equal("Fizz", actualResult);
        }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]

    public void NumbersDivisibleByFiveButNotThreeReturnBuzz(int input)
        {
            var actualResult = FizzBuzz.GetFizzBuzzString(input);
            Assert.Equal("Buzz", actualResult);
        }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]

    public void NumbersDivisibleByThreeAndFiveReturnFizzBuzz(int input)
        {
            var actualResult = FizzBuzz.GetFizzBuzzString(input);
            Assert.Equal("FizzBuzz", actualResult);
        }

    }

   
}
