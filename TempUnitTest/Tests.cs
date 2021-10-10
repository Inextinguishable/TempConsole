using Xunit;

namespace TempUnitTest
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            var res = 2 * 2;
            Assert.Equal(4, res);
        }

        [Fact]
        public void Test2()
        {
            var res = 2 + 2;
            Assert.Equal(4, res);
        }

        [Fact]
        public void Test3()
        {
            var res = 2 + 2;
            Assert.Equal(4, res);
        }
    }
}
