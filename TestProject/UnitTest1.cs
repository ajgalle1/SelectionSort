using Xunit;
using Shouldly;
using SelectionSort;



namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            int[] testArray = { 5, 3, 2, 1, 4 };
            int[] expected = { 1, 2, 3, 4, 5 };
            //act
            var result = Program.Sort(testArray);
            //assert
            result.ShouldBe(expected);
        }
      
    }
}