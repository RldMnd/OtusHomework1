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

        /// <summary>
        /// ��������, ��� ��������� x^2+1 = 0 �� ����� ������ (������� ������� �������)
        /// </summary>
        [Test]
        public void NonRoot()
        {
            var obj = new Solver();
            Assert.That(0, Is.EqualTo(obj.Solve(1,0,1).Length));
        }
    }
}