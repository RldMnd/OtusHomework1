using HomeWork1;

namespace TestHomework1
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
            var obj = new Solver();
            Assert.That(1, Is.EqualTo(obj.Test()));
        }
    }
}