namespace xUnitTestEmpty_2022
{
    public class ApplicationShould
    {
        [Fact]
        public void Test1()
        {
            Random sut = new Random();
            Assert.InRange(sut.Next(0, 101), 0, 100);
        }
    }
}