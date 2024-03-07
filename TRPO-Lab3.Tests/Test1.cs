using NUnit.Framework.Constraints;
using System.Reflection.Metadata;
using TRPO_Lab3.Library;

namespace TRPO_Lab3.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void �omparison()
        {
            const float p = 50;
            const float a = 3;
            const float expected = 75;

            var result = 0.5 * p * a;

            Assert.AreEqual(expected, result);
        }
    }
}