using ClassLibrary1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestFixture]
    class Class3
    {
        public IEnumerable<TestCaseData> TestCases { get; set; }
        [Test]
        [TestCase(18, 28, ExpectedResult = 46)]
        public int Test(int a,int b)
        {
            //Arrange
            var total = new TotalPrice();

            //Act 
            return total.Sum(a,b);
        }
    }
}
