using NUnit.Framework;
using NUint_Test_Sample;
namespace NUnit_Test_Project
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            var ex = new Sample();
            var input = "abc";

            //Act
            var actual = ex.Reverse(input);

            //Assert
            var expected = "cba";
            Assert.AreEqual(expected, actual);

        }
    }
}