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

        /// <summary>
        /// �������� �������
        /// ��� ��������� x^2-1 = 0 ���� ��� ����� ��������� 1 (x1=1, x2=-1)
        /// </summary>
        [Test]
        public void TwoRoot()
        {
            var obj = new Solver();
            var solve = obj.Solve(1,0,-1);
            Assert.That(solve.Length, Is.EqualTo(2));
            Assert.That(solve.Contains(1), Is.EqualTo(true));
            Assert.That(solve.Contains(-1), Is.EqualTo(true));
        }
    }
}