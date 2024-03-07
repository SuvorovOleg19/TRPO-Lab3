using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRPO_Lab3.Library;

namespace TRPO_Lab3.Tests
{
    [TestFixture]
    public class Test3
    {
        [Test]
        public void Check2()
        {
            const float p = -5;
            const float a = 7;

            Assert.Throws<ArgumentException>(() => Lateral_Surface_Regular_Piramid.Lateral_Surface_Regular_Piramid_formula(p, a));
        }
    }
}
