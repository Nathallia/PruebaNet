using LibreriaNet;

namespace Tests
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
            int count = Utils.CountRegexMatchs("prueba", "[a|b]");

            Assert.That(count, Is.GreaterThan(0));
        }
    }
}