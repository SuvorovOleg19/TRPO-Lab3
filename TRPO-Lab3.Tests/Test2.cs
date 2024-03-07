using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRPO_Lab3.Library;

namespace TRPO_Lab3.Tests
{
    [TestFixture]
    public class Test2
    {
        [Test]
        public void Check()
        {
            const float p = -7;
            const float a = 3;

            Assert.Throws<ArgumentException>(() => Lateral_Surface_Regular_Piramid.Lateral_Surface_Regular_Piramid_formula(p, a));
        }
    }
}
