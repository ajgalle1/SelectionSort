using Xunit;
using Shouldly;
using SelectionSort;



namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestSort()
        {
            //arrange
            int[] testArray = { 5, 3, 2, 1, 4 };
            int[] expected = { 1, 2, 3, 4, 5 };
            //act
            var result = Program.Sort(testArray);
            //assert
            result.ShouldBe(expected);
        }
        [Fact]
        public void TestReverseSort()
        {
            //arrange
            int[] testArray2 = { 1, 3, 2, 0, 99, -44, 0 };
            int[] expected2  = { 99, 3, 2, 1, 0, 0, -44 };
            //act
            var result = Program.ReverseSort(testArray2);
            //assert
            result.ShouldBe(expected2);
        }

    }
}