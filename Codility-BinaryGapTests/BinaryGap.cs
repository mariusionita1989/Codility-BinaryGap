using Codility_BinaryGap;

namespace Codility_BinaryGapTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestSolution_WithN15_ShouldReturn0()
        {
            Solution solution = new Solution();
            int result = solution.solution(15);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestSolution_WithN32_ShouldReturn0()
        {
            Solution solution = new Solution();
            int result = solution.solution(32);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestSolution_WithN1041_ShouldReturn5()
        {
            Solution solution = new Solution();
            int result = solution.solution(1041);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestSolution_WithN529_ShouldReturn4()
        {
            Solution solution = new Solution();
            int result = solution.solution(529);
            Assert.Equal(4, result);
        }

        [Fact]
        public void TestSolution_WithN20_ShouldReturn1()
        {
            Solution solution = new Solution();
            int result = solution.solution(20);
            Assert.Equal(1, result);
        }
    }
}